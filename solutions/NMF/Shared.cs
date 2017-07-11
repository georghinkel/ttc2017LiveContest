using NMF.Analyses;
using NMF.Transformations;
using NMF.Transformations.Core;
using NMF.Utilities;
using System.Collections.Generic;
using System.Linq;
using TTC2017.LiveContest.RefinementsEcore;
using TTC2017.LiveContest.SimpleCodeDOM;

namespace TTC2017.LiveContest
{
    public class SharedTransformation : ReflectiveTransformation
    {
        public class Package2Package : TransformationRule<IEPackage, Package>
        {
            public override void Transform(IEPackage input, Package output, ITransformationContext context)
            {
                output.Name = input.Name;
            }

            public override void RegisterDependencies()
            {
                RequireMany(Rule<Class2Class>(),
                    p => p.EClassifiers.OfType<IEClass>(),
                    (p, cls) => p.Types.AddRange(cls));
                RequireMany(Rule<Class2Interface>(),
                    p => p.EClassifiers.OfType<IEClass>(),
                    (p, cls) => p.Types.AddRange(cls));
            }
        }

        public class Class2Class : TransformationRule<IEClass, Class>
        {
            private Reference2Member reference2Member;
            private RefinedReference2Member refinedReference2Member;

            public override void Transform(IEClass input, Class output, ITransformationContext context)
            {
                output.Name = input.Name + "Impl";

                IEnumerable<IEStructuralFeature> shadows;
                var implementationBaseClass = FindBaseClass(input, out shadows);

                if (implementationBaseClass != null)
                {
                    output.BaseTypes.Add(new TypeReference { BaseName = implementationBaseClass.Name + "Impl" });
                }

                output.BaseTypes.Add(new TypeReference { BaseName = input.Name });

                var containedClasses = implementationBaseClass != null
                    ? implementationBaseClass.Closure(c => c.ESuperTypes)
                    : Enumerable.Empty<IEClass>();

                var allFeatures = AllFeatures(input).OfType<IEReference>();

                foreach (IEReference feature in allFeatures)
                {
                    if (!containedClasses.Contains(feature.EContainingClass))
                    {
                        if (!shadows.Contains(feature))
                        {
                            context.CallTransformation(reference2Member, feature, input);
                        }
                        else
                        {
                            context.CallTransformation(refinedReference2Member, feature, input);
                        }
                    }
                }
            }

            private static IEClass FindBaseClass(IEClass eClass, out IEnumerable<IEStructuralFeature> shadows)
            {
                shadows = Enumerable.Empty<IEStructuralFeature>();
                var ancestors = eClass.Closure(c => c.ESuperTypes);
                foreach (var layer in Layering<IEClass>.CreateLayers(eClass, c => Edges(c, ancestors)).Reverse())
                {
                    if (layer.Count == 1 && layer.First() != eClass && !shadows.IntersectsWith(AllFeatures(layer.First())))
                    {
                        return layer.First();
                    }
                    foreach (var cl in layer)
                    {
                        shadows = shadows.Union(Refinements(cl));
                    }
                }
                return null;
            }

            private static IEnumerable<IEClass> Edges(IEClass eClass, IEnumerable<IEClass> candidates)
            {
                var ancestors = eClass.Closure(c => c.ESuperTypes);
                var refinements = Refinements(eClass);
                var conflicting = from cand in candidates
                                  where !cand.Closure(c => c.ESuperTypes).Contains(eClass) &&
                                        refinements.IntersectsWith(AllFeatures(cand))
                                  select cand;

                return ancestors.Union(conflicting);
            }

            private static IEnumerable<IEStructuralFeature> AllFeatures(IEClass eClass)
            {
                return eClass.Closure(c => c.ESuperTypes).SelectMany(c => c.EStructuralFeatures);
            }

            private static IEnumerable<IEStructuralFeature> Refinements(IEClass eClass)
            {
                return from r in eClass.EStructuralFeatures.OfType<IEReference>()
                       where r.Refines != null
                       select r.Refines;
            }

            public override void RegisterDependencies()
            {
                reference2Member = Rule<Reference2Member>();
                refinedReference2Member = Rule<RefinedReference2Member>();
            }
        }

        public class Class2Interface : TransformationRule<IEClass, Class>
        {
            public override void Transform(IEClass input, Class output, ITransformationContext context)
            {
                output.Name = input.Name;
                output.IsInterface = true;

                foreach (var super in input.ESuperTypes)
                {
                    output.BaseTypes.Add(new TypeReference { BaseName = super.Name });
                }
            }

            public override void RegisterDependencies()
            {
                RequireMany(Rule<Reference2InterfaceMember>(),
                    cl => cl.EStructuralFeatures.OfType<IEReference>().PairWithConstant(cl));
            }
        }

        public class Reference2InterfaceMember : AbstractTransformationRule<IEReference, IEClass, Member> { }

        public class Reference2Member : AbstractTransformationRule<IEReference, IEClass, Member> { }

        public class RefinedReference2Member : AbstractTransformationRule<IEReference, IEClass, Member> { }
    }
}
