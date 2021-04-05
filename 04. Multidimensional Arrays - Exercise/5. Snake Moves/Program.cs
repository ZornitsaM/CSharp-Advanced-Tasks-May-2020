using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = dimensions[0];
            int columns = dimensions[1];

            var matrix = new char[rows, columns];
            string input = Console.ReadLine();

            var queue = new Queue<char>(input);

            for (int row = 0; row < rows; row++)
            {
                if (row % 2 != 0)
                {
                    for (int col = columns - 1; col >= 0; col--)
                    {
                        var current = queue.Dequeue();
                        matrix[row, col] = current;
                        queue.Enqueue(current);
                    }
                }

                else
                {
                    for (int col = 0; col < columns; col++)
                    {
                        var current = queue.Dequeue();
                        matrix[row, col] = current;
                        queue.Enqueue(current);

                    }
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();

            }
        }
    }
}
