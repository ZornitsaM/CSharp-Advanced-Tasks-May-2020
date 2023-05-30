using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputRowCol = int.Parse(Console.ReadLine());
            int rows = inputRowCol;
            int columns = inputRowCol;
            var matrix = new int[rows, columns];
            int sumDiagonal = 0;

            for (int row = 0; row < inputRowCol; row++)
            {
                var inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < inputRowCol; col++)
                {
                    matrix[row, col] = inputNumbers[col];

                    if (col == row)
                    {
                        sumDiagonal += matrix[row, col];
                    }
                }
            }
            Console.WriteLine(sumDiagonal);
        }
    }
}
