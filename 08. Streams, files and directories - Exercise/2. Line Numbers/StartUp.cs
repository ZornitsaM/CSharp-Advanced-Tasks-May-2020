using System;
using System.Linq;
using System.Collections.Generic;
 
namespace _2._Line_Numbers
{
    using System.IO;
    class Program
    {
        static void Main(string[] args)
        {
            string textPath = "text.txt";
            string outputPath = "output.txt";
            int count = 1;

            var textLines = File.ReadAllLines(textPath);

            foreach (var currentLine in textLines)
            {
                int lettersCount = currentLine.Count(char.IsLetter);
                int symbolsCount = currentLine.Count(char.IsPunctuation);

                File.AppendAllText(outputPath, $"Line {count}: {currentLine}({lettersCount})({symbolsCount}) {Environment.NewLine}");
                count++;
            }
        }
    }
}
