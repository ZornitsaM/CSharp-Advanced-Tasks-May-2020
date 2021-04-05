using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = dimensions[0];
            int columns = dimensions[1];

            int maxRow = 0;
            int maxCol = 0;
            int maxSum = int.MinValue;
            
            var matrix = new int[rows, columns];

            InitializeMatrix(matrix);

            for (int row = 0; row < rows-2; row++)
            {
                for (int col = 0; col < columns-2; col++)
                {
                   int curentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (curentSum>maxSum)
                    {
                        maxSum = curentSum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine($"{matrix[maxRow,maxCol]} {matrix[maxRow, maxCol+1]} {matrix[maxRow, maxCol+2]}");
            Console.WriteLine($"{matrix[maxRow+1, maxCol]} {matrix[maxRow+1, maxCol + 1]} {matrix[maxRow+1, maxCol + 2]}");
            Console.WriteLine($"{matrix[maxRow+2, maxCol]} {matrix[maxRow+2, maxCol + 1]} {matrix[maxRow+2, maxCol + 2]}");
        }

        private static void InitializeMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var inputNumbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputNumbers[col];
                }
            }
        }
    }
}
