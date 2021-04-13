using System;
using System.Linq;
using System.Collections.Generic;

namespace PO1
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputBombEffect = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var inputBombCasing = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Stack<int> bombEffect = new Stack<int>(inputBombEffect.Reverse());
            Stack<int> bombCasing = new Stack<int>(inputBombCasing);

            int daturaBombs = 40;
            int cherryBombs = 60;
            int smokeDecoyBombs = 120;

            int daturaCrafted = 0;
            int cherryCrafted = 0;
            int smokeCrafted = 0;

            bool isThreeCrafted = false;


            while (true)
            {
                if (bombEffect.Count == 0 || bombCasing.Count == 0)
                {
                    break;
                }

                if (daturaCrafted >= 3 && cherryCrafted >= 3 && smokeCrafted >= 3)
                {
                    isThreeCrafted = true;
                    break;

                }


                int currentEffect = bombEffect.Peek();
                int currentCasing = bombCasing.Peek();
                int sum = currentCasing + currentEffect;

                if (sum == daturaBombs)
                {
                    daturaCrafted++;
                    bombEffect.Pop();
                    bombCasing.Pop();
                }

                else if (sum == cherryBombs)
                {
                    cherryCrafted++;
                    bombEffect.Pop();
                    bombCasing.Pop();
                }

                else if (sum == smokeDecoyBombs)
                {
                    smokeCrafted++;
                    bombEffect.Pop();
                    bombCasing.Pop();
                }


                else
                {
                    currentCasing -= 5;
                    bombCasing.Pop();
                    bombCasing.Push(currentCasing);

                }


            }

            if (isThreeCrafted)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }

            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }


            if (bombEffect.Count > 0)
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", bombEffect)}");
            }

            else
            {
                Console.WriteLine("Bomb Effects: empty");
            }

            if (bombCasing.Count > 0)
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", bombCasing)}");
            }

            else
            {
                Console.WriteLine("Bomb Casings: empty");
            }


            Console.WriteLine($"Cherry Bombs: {cherryCrafted}");

            Console.WriteLine($"Datura Bombs: {daturaCrafted}");

            Console.WriteLine($"Smoke Decoy Bombs: {smokeCrafted}");






        }
    }
}
