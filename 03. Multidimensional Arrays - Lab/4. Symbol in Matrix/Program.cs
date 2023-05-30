using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimension = int.Parse(Console.ReadLine());
            int rows = dimension;
            int columns = dimension;
            var matrix = new char[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                var input = Console.ReadLine();

                for (int col = 0; col < columns; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            char symbol = char.Parse(Console.ReadLine());
            int foundRow = 0;
            int foundColumn = 0;
            bool isFound = false;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    char currentChar = matrix[row, col];

                    if (currentChar==symbol)
                    {
                        foundColumn = col;
                        foundRow = row;
                        isFound = true;
                        break;
                    }
                }

                if (isFound)
                {
                    break;
                }
            }

            if (isFound)
            {
                Console.WriteLine($"({foundRow}, {foundColumn})");
            }

            else
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
