using NMF.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTC2017.LiveContest.RefinementsEcore;

namespace TTC2017.LiveContest
{
    class ExampleModels
    {
        public static EPackage GenerateModel1()
        {
            var package = new EPackage
            {
                Name = "model1",
                NsPrefix = "model1",
                NsURI = "http://www.transformation-tool-contest.eu/2017/LiveContest/testModels/model1"
            };

            var classA = new EClass { Name = "A" };
            var classB = new EClass { Name = "B" };
            var classC = new EClass { Name = "C" };
            var classD = new EClass { Name = "D" };

            classA.EStructuralFeatures.Add(new EReference
            {
                Name = "PropA",
                EType = classD
            });
            classB.EStructuralFeatures.Add(new EReference
            {
                Name = "PropB",
                EType = classD
            });
            classC.EStructuralFeatures.Add(new EReference
            {
                Name = "PropC",
                EType = classD,
                Refines = classA.EStructuralFeatures[0] as IEReference
            });

            classB.ESuperTypes.Add(classA);
            classC.ESuperTypes.Add(classA);

            package.EClassifiers.Add(classA);
            package.EClassifiers.Add(classB);
            package.EClassifiers.Add(classC);
            package.EClassifiers.Add(classD);
            return package;
        }
        public static EPackage GenerateModel2()
        {
            var package = new EPackage
            {
                Name = "model2",
                NsPrefix = "model2",
                NsURI = "http://www.transformation-tool-contest.eu/2017/LiveContest/testModels/model2"
            };

            var classA = new EClass { Name = "A" };
            var classB = new EClass { Name = "B" };
            var classC = new EClass { Name = "C" };
            var classD = new EClass { Name = "D" };
            var classE = new EClass { Name = "E" };

            classA.EStructuralFeatures.Add(new EReference
            {
                Name = "PropA",
                EType = classE
            });
            classB.EStructuralFeatures.Add(new EReference
            {
                Name = "PropB",
                EType = classE,
                Refines = classA.EStructuralFeatures[0] as IEReference
            });
            classC.EStructuralFeatures.Add(new EReference
            {
                Name = "PropC",
                EType = classE
            });
            classD.EStructuralFeatures.Add(new EReference
            {
                Name = "PropD",
                EType = classE
            });

            classB.ESuperTypes.Add(classA);
            classC.ESuperTypes.Add(classA);
            classD.ESuperTypes.Add(classB);
            classD.ESuperTypes.Add(classC);

            package.EClassifiers.Add(classA);
            package.EClassifiers.Add(classB);
            package.EClassifiers.Add(classC);
            package.EClassifiers.Add(classD);
            package.EClassifiers.Add(classE);
            
            return package;
        }
        public static EPackage GenerateModel3()
        {
            var package = new EPackage
            {
                Name = "model3",
                NsPrefix = "model3",
                NsURI = "http://www.transformation-tool-contest.eu/2017/LiveContest/testModels/model3"
            };

            var classA = new EClass { Name = "A" };
            var classB = new EClass { Name = "B" };
            var classC = new EClass { Name = "C" };
            var classD = new EClass { Name = "D" };
            var classE = new EClass { Name = "E" };

            classA.EStructuralFeatures.Add(new EReference
            {
                Name = "PropA",
                EType = classE
            });
            classB.EStructuralFeatures.Add(new EReference
            {
                Name = "PropB",
                EType = classE
            });
            classC.EStructuralFeatures.Add(new EReference
            {
                Name = "PropC",
                EType = classE,
                Refines = classA.EStructuralFeatures[0] as IEReference
            });
            classD.EStructuralFeatures.Add(new EReference
            {
                Name = "PropD",
                EType = classE
            });

            classB.ESuperTypes.Add(classA);
            classC.ESuperTypes.Add(classA);
            classD.ESuperTypes.Add(classB);
            classD.ESuperTypes.Add(classC);

            package.EClassifiers.Add(classA);
            package.EClassifiers.Add(classB);
            package.EClassifiers.Add(classC);
            package.EClassifiers.Add(classD);
            package.EClassifiers.Add(classE);
            return package;
        }
        public static EPackage GenerateModel4()
        {
            var package = new EPackage
            {
                Name = "model4",
                NsPrefix = "model4",
                NsURI = "http://www.transformation-tool-contest.eu/2017/LiveContest/testModels/model4"
            };

            var classA = new EClass { Name = "A" };
            var classB = new EClass { Name = "B" };
            var classC = new EClass { Name = "C" };
            var classD = new EClass { Name = "D" };
            var classE = new EClass { Name = "E" };

            classA.EStructuralFeatures.Add(new EReference
            {
                Name = "PropA",
                EType = classE
            });
            classB.EStructuralFeatures.Add(new EReference
            {
                Name = "PropB",
                EType = classE,
                Refines = classA.EStructuralFeatures[0] as IEReference
            });
            classC.EStructuralFeatures.Add(new EReference
            {
                Name = "PropC",
                EType = classE
            });
            classD.EStructuralFeatures.Add(new EReference
            {
                Name = "PropD",
                EType = classE,
                Refines = classB.EStructuralFeatures[0] as IEReference
            });

            classB.ESuperTypes.Add(classA);
            classC.ESuperTypes.Add(classA);
            classD.ESuperTypes.Add(classB);
            classD.ESuperTypes.Add(classC);

            package.EClassifiers.Add(classA);
            package.EClassifiers.Add(classB);
            package.EClassifiers.Add(classC);
            package.EClassifiers.Add(classD);
            package.EClassifiers.Add(classE);

            return package;
        }
    }
}
