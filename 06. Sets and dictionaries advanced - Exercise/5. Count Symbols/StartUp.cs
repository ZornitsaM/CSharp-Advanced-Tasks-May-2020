using System;
using System.Linq;
using System.Collections.Generic;

namespace _5._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();
            var dic = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!dic.ContainsKey(input[i]))
                {
                    dic[input[i]] = 1;
                }

                else
                {
                    dic[input[i]] += 1;
                }
            }

            var sortedDic = dic.OrderBy(x => x.Key).ToArray();

            foreach (var item in sortedDic)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
