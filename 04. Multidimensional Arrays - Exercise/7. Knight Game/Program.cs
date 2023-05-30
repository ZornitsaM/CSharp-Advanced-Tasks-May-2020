using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace _7._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            var matrix = new char[size, size];

            for (int row = 0; row < size; row++)
            {
                var input = Console.ReadLine().ToCharArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int maxAttacks = 0;
            int killerRow = 0;
            int killerCol = 0;
            int knightsCount = 0;

            while (true)
            {
                maxAttacks = 0;

                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        int currentKnightAttacks = 0;
                        if (matrix[row, col] == 'K')
                        {
                            if (isInside(matrix, row - 2, col + 1) && matrix[row - 2, col + 1] == 'K')
                            {
                                currentKnightAttacks++;
                            }

                            if (isInside(matrix, row - 2, col - 1) && matrix[row - 2, col - 1] == 'K')
                            {
                                currentKnightAttacks++;
                            }

                            if (isInside(matrix, row - 1, col - 2) && matrix[row - 1, col - 2] == 'K')
                            {
                                currentKnightAttacks++;
                            }

                            if (isInside(matrix, row - 1, col + 2) && matrix[row - 1, col + 2] == 'K')
                            {
                                currentKnightAttacks++;
                            }

                            if (isInside(matrix, row + 1, col + 2) && matrix[row + 1, col + 2] == 'K')
                            {
                                currentKnightAttacks++;
                            }
                            if (isInside(matrix, row + 1, col - 2) && matrix[row + 1, col - 2] == 'K')
                            {
                                currentKnightAttacks++;
                            }

                            if (isInside(matrix, row + 2, col + 1) && matrix[row + 2, col + 1] == 'K')
                            {
                                currentKnightAttacks++;
                            }

                            if (isInside(matrix, row + 2, col - 1) && matrix[row + 2, col - 1] == 'K')
                            {
                                currentKnightAttacks++;
                            }
                        }

                        if (currentKnightAttacks > maxAttacks)
                        {
                            maxAttacks = currentKnightAttacks;
                            killerRow = row;
                            killerCol = col;
                        }
                    }
                }

                if (maxAttacks > 0)
                {
                    matrix[killerRow, killerCol] = '0';
                    knightsCount++;
                }
                else
                {
                    Console.WriteLine(knightsCount);
                    break;
                }
            }
        }

        private static bool isInside(char[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
        }
    }
}
