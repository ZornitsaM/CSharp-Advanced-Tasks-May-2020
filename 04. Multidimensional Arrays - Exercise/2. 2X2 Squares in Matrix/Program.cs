using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace _2.__2X2_Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimensions[0];
            int columns = dimensions[1];
            var matrix = new char[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                var inputSymbols = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < columns; col++)
                {
                    matrix[row, col] = inputSymbols[col];
                }
            }

            int counter = 0;

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < columns - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1] && matrix[row + 1, col]
                        == matrix[row + 1, col + 1] && matrix[row, col] == matrix[row + 1, col])
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
