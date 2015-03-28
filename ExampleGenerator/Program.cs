// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="OxyPlot">
//   The MIT License (MIT)
//   
//   Copyright (c) 2014 OxyPlot contributors
//   
//   Permission is hereby granted, free of charge, to any person obtaining a
//   copy of this software and associated documentation files (the
//   "Software"), to deal in the Software without restriction, including
//   without limitation the rights to use, copy, modify, merge, publish,
//   distribute, sublicense, and/or sell copies of the Software, and to
//   permit persons to whom the Software is furnished to do so, subject to
//   the following conditions:
//   
//   The above copyright notice and this permission notice shall be included
//   in all copies or substantial portions of the Software.
//   
//   THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS
//   OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
//   MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
//   IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
//   CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
//   TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
//   SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace ExampleGenerator
{
    using System;
    using System.IO;
    using System.Reflection;

    using OxyPlot;
    using OxyPlot.WindowsForms;

    public static class Program
    {
        public static string OutputDirectory { get; set; }

        public static bool ExportPng { get; set; }

        public static bool ExportPdf { get; set; }

        public static bool ExportSvg { get; set; }

        public static void Main(string[] args)
        {
            ExportPng = true;
            ExportPdf = true;
            ExportSvg = true;
            OutputDirectory = @".";
            if (args.Length > 0)
            {
                OutputDirectory = args[0];
            }

            foreach (var type in Assembly.GetExecutingAssembly().GetTypes())
            {
                foreach (var method in type.GetMethods(BindingFlags.Static | BindingFlags.Public))
                {
                    var exportAttribute = method.GetCustomAttribute<ExportAttribute>();
                    if (exportAttribute == null)
                    {
                        continue;
                    }

                    var model = (PlotModel)method.Invoke(null, null);
                    Export(model, exportAttribute.Filename);
                }
            }
        }

        private static void Export(PlotModel model, string name)
        {
            var fileName = Path.Combine(OutputDirectory, name + ".png");
            var directory = Path.GetDirectoryName(fileName) ?? ".";
            
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            if (ExportPng)
            {
                Console.WriteLine(fileName);
                using (var stream = File.Create(fileName))
                {
                    var exporter = new PngExporter { Width = 600, Height = 400 };
                    exporter.Export(model, stream);
                }
            }

            if (ExportPdf)
            {
                fileName = Path.ChangeExtension(fileName, ".pdf");
                Console.WriteLine(fileName);
                using (var stream = File.Create(fileName))
                {
                    var exporter = new PdfExporter { Width = 600d * 72 / 96, Height = 400d * 72 / 96 };
                    exporter.Export(model, stream);
                }
            }

            if (ExportSvg)
            {
                fileName = Path.ChangeExtension(fileName, ".svg");
                Console.WriteLine(fileName);

                using (var stream = File.Create(fileName))
                {
                    using (var exporter = new OxyPlot.WindowsForms.SvgExporter { Width = 600, Height = 400, IsDocument = true })
                    {
                        exporter.Export(model, stream);
                    }
                }
            }
        }
    }
}