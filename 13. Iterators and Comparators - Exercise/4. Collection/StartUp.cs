using System;
using System.Linq;
using System.Collections.Generic;

namespace Collection
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var myList = new List<string>();

            string command = Console.ReadLine();
            List<string> elements = command.Split().Skip(1).ToList();
            ListyIterator<string> listyIterator = new ListyIterator<string>(elements);

            while (command != "END")
            {
                if (command == "Print")
                {
                    try
                    {
                        listyIterator.Print();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (command == "Move")
                {
                    bool result = listyIterator.Move();
                    Console.WriteLine(result);
                }
                else if (command == "HasNext")
                {
                    bool result = listyIterator.HasNext();
                    Console.WriteLine(result);
                }
                else if (command == "PrintAll")
                {
                    foreach (var item in listyIterator)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                }
                command = Console.ReadLine();
            }
        }
    }
}
