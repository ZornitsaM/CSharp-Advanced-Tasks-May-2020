using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            var matrix = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                matrix[row] = input;
            }


            string command = Console.ReadLine();

            while (command!="END")
            {
                var splittedCommand = command.Split();
                int row = int.Parse(splittedCommand[1]);
                int col = int.Parse(splittedCommand[2]);
                int value = int.Parse(splittedCommand[3]);

                if (splittedCommand[0]=="Add")
                {
                    if (row>=0&& row<rows && col>=0&& col<matrix[row].Length)
                    {
                        matrix[row][col] += value;
                    }

                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }


                else if (splittedCommand[0]== "Subtract")
                {
                    if (row >= 0 && row < rows && col >= 0 && col < matrix[row].Length)
                    {
                        matrix[row][col] -= value;
                    }

                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                command = Console.ReadLine();
            }
            foreach (var item in matrix)
            {
                Console.WriteLine($"{string.Join(" ", item)}");
            }
        }
    }
}
