using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace _3._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> myFunc = x => char.IsUpper(x[0]);
            Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Where(myFunc).ToList().ForEach(Console.WriteLine);
        }
    }
}
