using NMF.Transformations;
using NMF.Transformations.Core;
using NMF.Utilities;
using System.Linq;
using TTC2017.LiveContest.RefinementsEcore;
using TTC2017.LiveContest.SimpleCodeDOM;

namespace TTC2017.LiveContest
{
    public class TransformationA : SharedTransformation
    {
        public class Reference2InterfaceProperty : TransformationRule<IEReference, IEClass, Property>
        {
            public override void Transform(IEReference reference, IEClass scope, Property output, ITransformationContext context)
            {
                output.Name = reference.Name;
                output.PropertyType = new TypeReference { BaseName = reference.EType.Name };
                output.IsAbstract = true;

                var cl = context.Trace.ResolveIn(Rule<Class2Interface>(), scope);
                cl.Members.Add(output);
            }

            public override void RegisterDependencies()
            {
                MarkInstantiatingFor(Rule<Reference2InterfaceMember>());
            }
        }

        public class Reference2Property : TransformationRule<IEReference, IEClass, Property>
        {
            public override void Transform(IEReference reference, IEClass scope, Property output, ITransformationContext context)
            {
                output.Name = reference.Name;
                output.PropertyType = new TypeReference { BaseName = reference.EType.Name };

                var backingField = new Field
                {
                    Name = "_" + reference.Name,
                    FieldType = new TypeReference
                    {
                        BaseName = output.PropertyType.BaseName
                    }
                };
                output.Getter = new FieldReferenceExpression
                {
                    FieldName = backingField.Name,
                    TargetObject = new ThisReferenceExpression()
                };
                output.Setter = new BinaryExpression
                {
                    LeftOperand = new FieldReferenceExpression
                    {
                        FieldName = backingField.Name,
                        TargetObject = new ThisReferenceExpression()
                    },
                    Operator = BinaryOperator.Assign,
                    RightOperand = new SetValueExpression()
                };

                var cl = context.Trace.ResolveIn(Rule<Class2Class>(), scope);
                cl.Members.Add(output);
                cl.Members.Add(backingField);
            }

            public override void RegisterDependencies()
            {
                MarkInstantiatingFor(Rule<Reference2Member>());
            }
        }
        
        public class RefinedReference2Property : TransformationRule<IEReference, IEClass, Property>
        {
            public override void Transform(IEReference reference, IEClass scope, Property output, ITransformationContext context)
            {
                output.Name = reference.Name;
                output.PropertyType = new TypeReference { BaseName = reference.EType.Name };

                var refiningReference = scope.Closure(c => c.ESuperTypes)
                    .SelectMany(c => c.EStructuralFeatures.OfType<IEReference>())
                    .Where(r => r.Refines == reference)
                    .FirstOrDefault();
                
                output.Getter = new FieldReferenceExpression
                {
                    FieldName = refiningReference.Name,
                    TargetObject = new ThisReferenceExpression()
                };
                output.Setter = new BinaryExpression
                {
                    LeftOperand = new FieldReferenceExpression
                    {
                        FieldName = refiningReference.Name,
                        TargetObject = new ThisReferenceExpression()
                    },
                    Operator = BinaryOperator.Assign,
                    RightOperand = new SetValueExpression()
                };

                var cl = context.Trace.ResolveIn(Rule<Class2Class>(), scope);
                cl.Members.Add(output);
            }

            public override void RegisterDependencies()
            {
                MarkInstantiatingFor(Rule<RefinedReference2Member>());
            }
        }
    }
}
