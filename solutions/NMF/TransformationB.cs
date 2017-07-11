using NMF.Transformations;
using NMF.Transformations.Core;
using NMF.Utilities;
using System.Linq;
using TTC2017.LiveContest.RefinementsEcore;
using TTC2017.LiveContest.SimpleCodeDOM;

namespace TTC2017.LiveContest
{
    public class TransformationB : SharedTransformation
    {
        public class Reference2InterfaceMethod : TransformationRule<IEReference, IEClass, Method>
        {
            public override void Transform(IEReference reference, IEClass scope, Method output, ITransformationContext context)
            {
                output.Name = "get_" + reference.Name;
                output.ReturnType = new TypeReference { BaseName = reference.EType.Name };
                output.IsAbstract = true;

                var cl = context.Trace.ResolveIn(Rule<Class2Interface>(), scope);
                cl.Members.Add(output);
            }

            public override void RegisterDependencies()
            {
                MarkInstantiatingFor(Rule<Reference2InterfaceMember>());
            }
        }
        public class Reference2Property : TransformationRule<IEReference, IEClass, Method>
        {
            public override void Transform(IEReference reference, IEClass scope, Method output, ITransformationContext context)
            {
                output.Name = "get_" + reference.Name;
                output.ReturnType = new TypeReference { BaseName = reference.EType.Name };

                var resolve = new MethodInvokeExpression
                {
                    MethodName = "resolve"
                };
                resolve.Arguments.Add(new ThisReferenceExpression());
                resolve.Arguments.Add(new StringLiteralExpression { Value = reference.Name });
                output.BodyExpression = resolve;

                var cl = context.Trace.ResolveIn(Rule<Class2Class>(), scope);
                cl.Members.Add(output);
            }

            public override void RegisterDependencies()
            {
                MarkInstantiatingFor(Rule<Reference2Member>());
            }
        }

        public class RefinedReference2Property : TransformationRule<IEReference, IEClass, Method>
        {
            public override void Transform(IEReference reference, IEClass scope, Method output, ITransformationContext context)
            {
                output.Name = "get_" + reference.Name;
                output.ReturnType = new TypeReference { BaseName = reference.EType.Name };

                var refiningReference = scope.Closure(c => c.ESuperTypes)
                    .SelectMany(c => c.EStructuralFeatures.OfType<IEReference>())
                    .Where(r => r.Refines == reference)
                    .FirstOrDefault();

                output.BodyExpression = new MethodInvokeExpression
                {
                    TargetObject = new ThisReferenceExpression(),
                    MethodName = "get_" + refiningReference.Name
                };

                var cl = context.Trace.ResolveIn(Rule<Class2Class>(), scope);
                cl.Members.Add(output);
            }

            public override void RegisterDependencies()
            {
                MarkInstantiatingFor(Rule<RefinedReference2Member>());
            }
        }

        [OverrideRule]
        public class Class2DBObject : Class2Class
        {
            public override void Transform(IEClass input, Class output, ITransformationContext context)
            {
                base.Transform(input, output, context);
                if (output.BaseTypes.Count == 1)
                {
                    output.BaseTypes.Insert(0, new TypeReference { BaseName = "DBObject" });
                }
            }
        }
    }
}
