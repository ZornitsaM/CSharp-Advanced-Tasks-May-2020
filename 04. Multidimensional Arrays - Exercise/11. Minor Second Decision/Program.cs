using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Demo
{
    class Program
    {
        static char[,] matrix;
        static int coals;
        static int startRow;
        static int startCol;

        static void Main(string[] args)
        {
            int dimensions = int.Parse(Console.ReadLine());
            var commands = Console.ReadLine().Split();

            matrix = new char[dimensions, dimensions];

            PopulateMatrix();

            for (int i = 0; i < commands.Length; i++)
            {
                var currentCommand = commands[i];
                if (currentCommand == "left")
                {
                    Move(0, -1);
                }

                else if (currentCommand == "right")
                {
                    Move(0, +1);
                }

                else if (currentCommand == "up")
                {
                    Move(-1, 0);
                }

                else if (currentCommand == "down")
                {
                    Move(+1, 0);
                }
            }

            Console.WriteLine($"{coals} coals left. ({startRow}, {startCol})");
        }

        private static void Move(int row, int col)
        {
            if (isInside(matrix, startRow + row, startCol + col))
            {
                startRow += row;
                startCol += col;

                if (matrix[startRow, startCol] == 'e')
                {
                    Console.WriteLine($"Game over! ({startRow}, {startCol})");
                    Environment.Exit(0);
                }

                else if (matrix[startRow, startCol] == 'c')
                {
                    coals--;
                    matrix[startRow, startCol] = '*';

                    if (coals == 0)
                    {
                        Console.WriteLine($"You collected all coals! ({startRow}, {startCol})");
                        Environment.Exit(0);
                    }
                }
            }
        }

        private static bool isInside(char[,] matrix, int startRow, int startCol)
        {
            return startRow >= 0 && startRow < matrix.GetLength(0) && startCol >= 0 && startCol < matrix.GetLength(1);
        }

        private static void PopulateMatrix()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var input = Console.ReadLine().Split().Select(char.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];

                    if (matrix[row, col] == 's')
                    {
                        startRow = row;
                        startCol = col;
                    }

                    else if (matrix[row, col] == 'c')
                    {
                        coals++;
                    }
                }
            }
        }
    }
}
