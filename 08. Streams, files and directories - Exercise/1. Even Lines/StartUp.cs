using System;
using System.Linq;
using System.Collections.Generic;

namespace Streams__Files_and_Directories_EX
{
    using System;
    using System.Text;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            string textFilePath = @"text.txt";
            
            using (var streamReader = new StreamReader(textFilePath))
            {
                int cnt = 0;

                while (true)
                {
                    string currentLine = streamReader.ReadLine();
                 
                    if (currentLine==null)
                    {
                        break;
                    }
                    if (cnt%2==0)
                    {
                        string replacedSymbols = ReplacedSpecialChar(currentLine);
                        string reversedWords = ReverseWords(replacedSymbols);
                        Console.WriteLine(reversedWords);
                    }
                    cnt++;
                }
            }
        }

        private static string ReverseWords(string replacedSymbols)
        {
            return string.Join(" ", replacedSymbols.Split().Reverse());
        }

        private static string ReplacedSpecialChar(string currentLine)
        {
            return currentLine.Replace('-', '@').Replace('.', '@').Replace(',', '@').
                  Replace('!', '@').Replace('?', '@');
        }
    }
}
