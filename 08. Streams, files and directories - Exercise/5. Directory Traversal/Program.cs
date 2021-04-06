using System;
using System.Linq;
using System.Collections.Generic;

namespace _5._Directory_Traversal
{
    using System.IO;
    class Program
    {
        static void Main(string[] args)
        {
            var fileArray = Directory.GetFiles(".", "*.*");

            var dirInfo = new Dictionary<string, Dictionary<string, double>>();
            var directoryInfo = new DirectoryInfo("."); //-->настоящата папка, от която стартираме

            var allFiles = directoryInfo.GetFiles();

            foreach (FileInfo currentFile in allFiles)
            {
                double sized = currentFile.Length / 1024d;
                string fileName = currentFile.Name;
                string extensions = currentFile.Extension;

                if (!dirInfo.ContainsKey(extensions))
                {
                    dirInfo.Add(extensions, new Dictionary<string, double>());
                }

                if (!dirInfo[extensions].ContainsKey(fileName))
                {
                    dirInfo[extensions].Add(fileName, sized);
                }


                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/report.txt";

                var sortedDictionary = dirInfo.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);


                foreach (var (extension, value) in sortedDictionary)
                {
                    File.AppendAllText(path, extension + Environment.NewLine);

                    foreach (var (filename, size) in value.OrderBy(x => x.Value))
                    {
                        File.AppendAllText(path, ($"--{filename} - {size:f3}kb" + Environment.NewLine));
                    }
                }

            }
        }
    }
}
