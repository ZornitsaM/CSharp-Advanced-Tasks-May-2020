using System;
using System.Linq;
using System.Collections.Generic;

namespace PO2
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimnesions = int.Parse(Console.ReadLine());
            int rows = dimnesions;
            int cols = dimnesions;
            int rowSnake= 0;
            int colSnake = 0;

            int rowFirstB = 0;
            int colFirstB = 0;
            int rowSecondB = 0;
            int colSecondB = 0;
            bool isFirstB = false;
            int counterFood = 0;


            var matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var input = Console.ReadLine().ToCharArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                    if (matrix[row, col]=='S')
                    {
                        rowSnake = row;
                        colSnake = col;
                    }

                    else if (matrix[row, col] == 'B')
                    {
                        if (!isFirstB)
                        {
                            rowFirstB = row;
                            colFirstB = col;
                            isFirstB = true;
                        }

                        else
                        {
                            rowSecondB = row;
                            colSecondB = col;
                        }
                       
                    }
                }

            }





            string command = Console.ReadLine();

            while (true)
            {
                if (command=="up")
                {
                    if (rowSnake>0)
                    {
                        rowSnake--;

                        if (matrix[rowSnake,colSnake]=='*')
                        {
                            counterFood++;
                            if (counterFood>=10)
                            {
                                Console.WriteLine("You won! You fed the snake.");
                                matrix[rowSnake, colSnake] = 'S';
                                matrix[rowSnake + 1, colSnake] = '.';
                                break;
                            }

                            matrix[rowSnake, colSnake] = 'S';
                            matrix[rowSnake + 1, colSnake] ='.';

                        }

                        else if (matrix[rowSnake, colSnake] == 'B')
                        {
                            matrix[rowSnake+1, colSnake] = '.';

                            if (rowSnake==rowFirstB&&colSnake==colFirstB)
                            {
                                matrix[rowSnake, colSnake] = '.';
                                rowSnake = rowSecondB;
                                colSnake = colSecondB;
                                matrix[rowSnake, colSnake] = 'S';
                            }

                            else if (rowSnake==rowSecondB&&colSnake==colSecondB)
                            {
                                matrix[rowSnake, colSnake] = '.';
                                rowSnake = rowFirstB;
                                colSnake = colFirstB;
                                matrix[rowSnake, colSnake] = 'S';

                            }
                        }

                        else
                        {
                            matrix[rowSnake, colSnake] = 'S';
                            matrix[rowSnake + 1, colSnake] ='.';

                        }


                    }

                    else
                    {
                        Console.WriteLine("Game over!");
                        matrix[rowSnake, colSnake] = '.';
                        break;
                    }

                }

                else if (command=="down")
                {

                    if (rowSnake <rows-1)
                    {
                        rowSnake++;

                        if (matrix[rowSnake, colSnake] == '*')
                        {
                            counterFood++;
                            if (counterFood >= 10)
                            {
                                Console.WriteLine("You won! You fed the snake.");
                                matrix[rowSnake, colSnake] = 'S';
                                matrix[rowSnake - 1, colSnake] = '.';
                                break;
                            }

                            matrix[rowSnake, colSnake] = 'S';
                            matrix[rowSnake - 1, colSnake] = '.';

                        }

                        else if (matrix[rowSnake, colSnake] == 'B')
                        {
                            matrix[rowSnake - 1, colSnake] = '.';

                            if (rowSnake == rowFirstB && colSnake == colFirstB)
                            {
                                matrix[rowSnake, colSnake] = '.';
                                rowSnake = rowSecondB;
                                colSnake = colSecondB;
                                matrix[rowSnake, colSnake] = 'S';
                            }

                            else if (rowSnake == rowSecondB && colSnake == colSecondB)
                            {
                                matrix[rowSnake, colSnake] = '.';
                                rowSnake = rowFirstB;
                                colSnake = colFirstB;
                                matrix[rowSnake, colSnake] = 'S';

                            }
                        }

                        else
                        {
                            matrix[rowSnake, colSnake] = 'S';
                            matrix[rowSnake - 1, colSnake] = '.';

                        }


                    }

                    else
                    {
                        Console.WriteLine("Game over!");
                        matrix[rowSnake, colSnake] = '.';
                        break;
                    }

                }

                else if (command=="left")
                {
                    if (colSnake>0)
                    {
                        colSnake--;

                        if (matrix[rowSnake, colSnake] == '*')
                        {
                            counterFood++;
                            if (counterFood >= 10)
                            {

                                Console.WriteLine("You won! You fed the snake.");
                                matrix[rowSnake, colSnake] = 'S';
                                matrix[rowSnake, colSnake + 1] = '.';
                                break;
                            }

                            matrix[rowSnake, colSnake] = 'S';
                            matrix[rowSnake, colSnake+1] = '.';

                        }

                        else if (matrix[rowSnake, colSnake] == 'B')
                        {
                            matrix[rowSnake, colSnake+1] = '.';

                            if (rowSnake == rowFirstB && colSnake == colFirstB)
                            {
                                matrix[rowSnake, colSnake] = '.';
                                rowSnake = rowSecondB;
                                colSnake = colSecondB;
                                matrix[rowSnake, colSnake] = 'S';
                            }

                            else if (rowSnake == rowSecondB && colSnake == colSecondB)
                            {
                                matrix[rowSnake, colSnake] = '.';
                                rowSnake = rowFirstB;
                                colSnake = colFirstB;
                                matrix[rowSnake, colSnake] = 'S';

                            }
                        }

                        else
                        {
                            matrix[rowSnake, colSnake] = 'S';
                            matrix[rowSnake, colSnake+1] = '.';

                        }


                    }

                    else
                    {
                        Console.WriteLine("Game over!");
                        matrix[rowSnake, colSnake] = '.';
                        break;
                    }


                }

                else if (command=="right")
                {
                    if (colSnake <cols-1)
                    {
                        colSnake++;

                        if (matrix[rowSnake, colSnake] == '*')
                        {
                            counterFood++;
                            if (counterFood >= 10)
                            {
                                Console.WriteLine("You won! You fed the snake.");
                                matrix[rowSnake, colSnake] = 'S';
                                matrix[rowSnake, colSnake - 1] = '.';
                                break;
                            }

                            matrix[rowSnake, colSnake] = 'S';
                            matrix[rowSnake, colSnake - 1] = '.';

                        }

                        else if (matrix[rowSnake, colSnake] == 'B')
                        {
                            matrix[rowSnake, colSnake - 1] = '.';

                            if (rowSnake == rowFirstB && colSnake == colFirstB)
                            {
                                matrix[rowSnake, colSnake] = '.';
                                rowSnake = rowSecondB;
                                colSnake = colSecondB;
                                matrix[rowSnake, colSnake] = 'S';
                            }

                            else if (rowSnake == rowSecondB && colSnake == colSecondB)
                            {
                                matrix[rowSnake, colSnake] = '.';
                                rowSnake = rowFirstB;
                                colSnake = colFirstB;
                                matrix[rowSnake, colSnake] = 'S';

                            }
                        }

                        else
                        {
                            matrix[rowSnake, colSnake] = 'S';
                            matrix[rowSnake, colSnake - 1] = '.';

                        }


                    }

                    else
                    {
                        Console.WriteLine("Game over!");
                         matrix[rowSnake, colSnake] = '.';
                        break;
                    }


                }


                command = Console.ReadLine();
            }

            Console.WriteLine($"Food eaten: {counterFood}");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]);

                }

                Console.WriteLine();
            }





        }
    }
}
