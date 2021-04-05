using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;


namespace Multidimensional_Arrays_EX
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimensions = int.Parse(Console.ReadLine());
            int rows = dimensions;
            int columns = dimensions;
            var matrixOne = new int[rows, columns];
            var matrixTwo = new int[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                var inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                var inputNumbersReversed = inputNumbers.Reverse().ToArray();

                for (int col = 0; col < columns; col++)
                {
                    matrixOne[row, col] = inputNumbers[col];
                    matrixTwo[row, col] = inputNumbersReversed[col];
                }
            }
            double sumPrimaryDiagonal = 0;
            double sumSecondaryDiagonal = 0;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    if (row==col)
                    {
                        sumPrimaryDiagonal += matrixOne[row, col];
                        sumSecondaryDiagonal += matrixTwo[row, col];
                    }
                }
            }
            double diff = Math.Abs(sumSecondaryDiagonal - sumPrimaryDiagonal);
            Console.WriteLine(diff);
        }
    }
}
