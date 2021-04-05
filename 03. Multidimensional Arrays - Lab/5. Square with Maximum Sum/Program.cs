using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace _5._Square_with_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            var dimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = dimensions[0];
            int columns = dimensions[1];

            var matrix = new int[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                var input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < columns; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int maxSum = int.MinValue;
            int numberUpLeft = 0;
            int numberUpRight = 0;
            int numberDownLeft = 0;
            int numberDownRight = 0;

            for (int row = 0; row < rows-1; row++)
            {
                for (int col = 0; col < columns-1; col++)
                {
                    var currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (currentSum>maxSum)
                    {
                        maxSum = currentSum;
                        numberUpLeft = matrix[row, col];
                        numberUpRight = matrix[row, col + 1];
                        numberDownLeft = matrix[row + 1, col];
                        numberDownRight = matrix[row + 1, col + 1];
                    }
                }
            }

            Console.WriteLine($"{numberUpLeft} {numberUpRight}");
            Console.WriteLine($"{numberDownLeft} {numberDownRight}");
            Console.WriteLine(maxSum);
        }
    }
}
