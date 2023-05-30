using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace _6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            byte rows = byte.Parse(Console.ReadLine());
            var matrix = new double[rows][];

            for (int row = 0; row < rows; row++)
            {
                var inputNumbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

                matrix[row] = inputNumbers;
            }

            for (int row = 0; row < rows - 1; row++)
            {
                if (matrix[row].Length == matrix[row + 1].Length)
                {
                    for (int current = 0; current < matrix[row].Length; current++)
                    {
                        matrix[row][current] *= 2;
                    }

                    for (int next = 0; next < matrix[row + 1].Length; next++)
                    {
                        matrix[row + 1][next] *= 2;
                    }
                }
                else
                {
                    for (int current = 0; current < matrix[row].Length; current++)
                    {
                        matrix[row][current] /= 2;
                    }
                    for (int next = 0; next < matrix[row + 1].Length; next++)
                    {
                        matrix[row + 1][next] /= 2;
                    }
                }
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                var commandArr = command.Split();
                int row = int.Parse(commandArr[1]);
                int col = int.Parse(commandArr[2]);
                int value = int.Parse(commandArr[3]);

                if (commandArr[0] == "Add" && row >= 0 && row < rows && col >= 0 && col < matrix[row].Length)
                {
                    matrix[row][col] += value;
                }
                else if (commandArr[0] == "Subtract" && row >= 0 && row < rows && col >= 0 && col < matrix[row].Length)
                {
                    matrix[row][col] -= value;
                }
                command = Console.ReadLine();
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
