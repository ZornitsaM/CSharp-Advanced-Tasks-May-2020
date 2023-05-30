using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Multidimensional_Arrays_LAB
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            var rows = input[0];
            var columns = input[1];
            var matrix = new int[rows, columns];
            int sumOutput = 0;

            for (int row = 0; row < rows; row++)
            {
                var inputNumbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < columns; col++)
                {
                    matrix[row, col] = inputNumbers[col];
                    sumOutput += matrix[row, col];

                }
            }
            Console.WriteLine(rows);
            Console.WriteLine(columns);
            Console.WriteLine(sumOutput);
        }
    }
}
