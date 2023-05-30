using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._Word_Count
{
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            string textPath = "text.txt";
            string wordsPath = "words.txt";
            var textLines = File.ReadAllLines(textPath);
            var words = File.ReadAllLines(wordsPath);
            var wordsInfo = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string currentWordLower = word.ToLower();
                if (!wordsInfo.ContainsKey(currentWordLower))
                {
                    wordsInfo.Add(currentWordLower, 0);
                }
            }

            foreach (var currentLine in textLines)
            {
                var currentLineWords = currentLine.ToLower().Split(new char[] { ',', ' ', '-', '!', '?', '.', '\'', ':', ';' });

                foreach (var currentWord in currentLineWords)
                {
                    if (wordsInfo.ContainsKey(currentWord))
                    { 
                        wordsInfo[currentWord] += 1;
                    }
                }
            }

            string actualResulPath = "actualResult.txt";
            string expectedResultPath ="expectedResult.txt";

            foreach (var (key,value) in wordsInfo)
            {
                File.AppendAllText(actualResulPath, $"{key} - {value}{Environment.NewLine}");
            }

            foreach (var (key,value) in wordsInfo.OrderByDescending(x=>x.Value))
            {
                File.AppendAllText(expectedResultPath, $"{key} - {value}{Environment.NewLine}");
            }
        }
    }
}
