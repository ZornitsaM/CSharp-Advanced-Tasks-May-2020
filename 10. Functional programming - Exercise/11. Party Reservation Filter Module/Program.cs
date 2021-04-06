using System;
using System.Linq;
using System.Collections.Generic;

namespace _11._Party_Reservation_Filter_Module
{
    class Program
    {
        static List<string> currentList;
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split().ToList();

            string command = Console.ReadLine();
            currentList = names;

            Func<string, string, bool> addFilterStart = (name, starts) => name.StartsWith(starts);
            Func<string, string, bool> addFilterEnd = (name, ends) => name.EndsWith(ends);
            Func<string, int, bool> nameLenght = (name, lenght) => name.Length == lenght;

            Func<string, string, bool> contains = (name, typeContains) => name.Contains(typeContains);

            while (command != "Print")
            {
                var currrentCommand = command.Split(';');

                if (currrentCommand[0] == "Add filter")
                {
                    string charSymbol = currrentCommand[2];

                    if (currrentCommand[1] == "Starts with")
                    {
                        currentList = currentList.Where(name => !addFilterStart(name, charSymbol)).ToList();
                    }

                    else if (currrentCommand[1] == "Ends with")
                    {
                        currentList = currentList.Where(name => !addFilterEnd(name, charSymbol)).ToList();
                    }

                    else if (currrentCommand[1] == "Length")
                    {
                        int lenght = int.Parse(currrentCommand[2]);
                        currentList = currentList.Where(x => !nameLenght(x, lenght)).ToList();
                    }

                    else if (currrentCommand[1] == "Contains")
                    {
                        currentList = currentList.Where(x => !contains(x, charSymbol)).ToList();
                    }
                }

                else if (currrentCommand[0] == "Remove filter")
                {
                    string charSymbol = currrentCommand[2];

                    if (currrentCommand[1] == "Starts with")
                    {
                        var temp = names.Where(name => addFilterStart(name, charSymbol)).ToList();

                        currentList.InsertRange(currentList.Count, temp);
                    }

                    else if (currrentCommand[1] == "Ends with")
                    {
                        var temp = names.Where(name => addFilterEnd(name, charSymbol)).ToList();
                        currentList.InsertRange(currentList.Count, temp);
                    }

                    else if (currrentCommand[1] == "Length")
                    {
                        int lenght = int.Parse(currrentCommand[2]);
                        var temp = names.Where(x => nameLenght(x, lenght)).ToList();
                        currentList.InsertRange(currentList.Count, temp);
                    }

                    else if (currrentCommand[1] == "Contains")
                    {
                        var temp = names.Where(x => contains(x, charSymbol)).ToList();
                        currentList.InsertRange(currentList.Count, temp);
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", currentList));
        }
    }
}
