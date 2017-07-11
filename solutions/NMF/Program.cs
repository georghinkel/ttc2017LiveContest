using NMF.Models.Repository;
using NMF.Transformations.Core;
using NMF.Transformations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTC2017.LiveContest.SimpleCodeDOM;
using TTC2017.LiveContest.RefinementsEcore;
using System.Diagnostics;

namespace TTC2017.LiveContest
{
    class Program
    {
        private static ModelRepository repository = new ModelRepository();
        private static TransformationA codeGenA = new TransformationA();
        private static TransformationB codeGenB = new TransformationB();
        private static Printer printer = new Printer();

        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                GenerateExampleModel(ExampleModels.GenerateModel1());
                GenerateExampleModel(ExampleModels.GenerateModel2());
                GenerateExampleModel(ExampleModels.GenerateModel3());
                GenerateExampleModel(ExampleModels.GenerateModel4());
            }
            else
            {
                var model = Environment.GetEnvironmentVariable("Model");
                var input = Environment.GetEnvironmentVariable("Input");
                var output = Environment.GetEnvironmentVariable("Output");
                var runIndex = Environment.GetEnvironmentVariable("RunIndex");
                if (args[0] == "transformA")
                {
                    var stopwatch = new Stopwatch();
                    stopwatch.Start();
                    var package = repository.Resolve(input).RootElements[0] as EPackage;
                    var codeA = TransformationEngine.Transform<IEPackage, Package>(package, codeGenA);
                    repository.Save(codeA, output);
                    stopwatch.Stop();
                    Console.WriteLine($"NMF;{model};A;{runIndex};Time;{stopwatch.Elapsed.Ticks * 100}");
                    Console.WriteLine($"NMF;{model};A;{runIndex};Memory;{Environment.WorkingSet}");
                }
                else if (args[0] == "transformB")
                {
                    var stopwatch = new Stopwatch();
                    stopwatch.Start();
                    var package = repository.Resolve(input).RootElements[0] as EPackage;
                    var codeA = TransformationEngine.Transform<IEPackage, Package>(package, codeGenB);
                    repository.Save(codeA, output);
                    stopwatch.Stop();
                    Console.WriteLine($"NMF;{model};B;{runIndex};Time;{stopwatch.Elapsed.Ticks * 100}");
                    Console.WriteLine($"NMF;{model};B;{runIndex};Memory;{Environment.WorkingSet}");
                }
                else if (args[0] == "print")
                {
                    var codeDom = repository.Resolve(output).RootElements[0] as Package;
                    printer.Print(codeDom, System.IO.Path.ChangeExtension(output, ".txt"));
                }
            }
        }

        private static void GenerateExampleModel(EPackage model)
        {
            repository.Save(model, $"models\\{model.Name}.xmi");

            var model_codeA = TransformationEngine.Transform<IEPackage, Package>(model, codeGenA);
            var model_codeB = TransformationEngine.Transform<IEPackage, Package>(model, codeGenB);

            repository.Save(model_codeA, $"expected_results\\{model.Name}_codeA.xmi");
            repository.Save(model_codeB, $"expected_results\\{model.Name}_codeB.xmi");
            
            printer.Print(model_codeA, $"expected_results\\{model.Name}_codeA.txt");
            printer.Print(model_codeB, $"expected_results\\{model.Name}_codeB.txt");
        }
    }
}
