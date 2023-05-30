using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int columns = dimensions[1];
            var matrix = new string[rows, columns];

            InitializeMatrix(matrix);

            string command = Console.ReadLine();

            while (command!="END")
            {
                var splittedCommand = command.Split();

                if (splittedCommand[0]=="swap" &&splittedCommand.Length==5)
                {
                    int rowOne = int.Parse(splittedCommand[1]);
                    int colOne = int.Parse(splittedCommand[2]);
                    int rowTwo = int.Parse(splittedCommand[3]);
                    int colTwo = int.Parse(splittedCommand[4]);

                    if (rowOne>=0&&rowOne<rows&&colOne>=0&&colOne<columns && rowTwo >= 0 && rowTwo < rows && colTwo >= 0 && colTwo < columns)
                    {
                        string currentNumber = matrix[rowOne, colOne];
                        string newNumber = matrix[rowTwo, colTwo];

                        matrix[rowOne, colOne] = newNumber;
                        matrix[rowTwo, colTwo] = currentNumber;

                        for (int row = 0; row < rows; row++)
                        {
                            for (int col = 0; col < columns; col++)
                            {
                                Console.Write(matrix[row,col] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                command = Console.ReadLine();
            }
        }

        private static void InitializeMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var inputNumbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputNumbers[col];
                }
            }
        }
    }
}
