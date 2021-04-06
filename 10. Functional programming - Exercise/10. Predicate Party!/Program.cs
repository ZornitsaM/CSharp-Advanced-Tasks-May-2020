using System;
using System.Linq;
using System.Collections.Generic;

namespace _10._Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split().ToList();

            string command = Console.ReadLine();

            Func<string, int, bool> lenghtFunc = (name, lenght) => name.Length == lenght;
            Func<string, string, bool> startsWithFunc = (name, starts) => name.StartsWith(starts);
            Func<string, string, bool> endsWith = (name, ends) => name.EndsWith(ends);

            while (command != "Party!")
            {
                var commandInfo = command.Split();
                string action = commandInfo[0];
                string condition = commandInfo[1];
                string param = commandInfo[2];

                if (action == "Double")
                {
                    if (condition == "Length")
                    {
                        int lenght = int.Parse(param);
                        var temp = names.Where(name => lenghtFunc(name, lenght)).ToList();

                        MyAddRange(names, temp);
                    }

                    else if (condition == "StartsWith")
                    {
                        var temp = names.Where(name => startsWithFunc(name, param)).ToList();
                        MyAddRange(names, temp);

                    }

                    else if (condition == "EndsWith")
                    {
                        var temp = names.Where(x => endsWith(x, param)).ToList();
                        MyAddRange(names, temp);
                    }
                }

                else if (action == "Remove")
                {
                    if (condition == "Length")
                    {
                        int lenght = int.Parse(param);

                        names = names.Where(name => !lenghtFunc(name, lenght)).ToList();
                    }

                    else if (condition == "StartsWith")
                    {
                        names = names.Where(name => !startsWithFunc(name, param)).ToList();
                    }

                    else if (condition == "EndsWith")
                    {
                        names = names.Where(x => !endsWith(x, param)).ToList();
                    }
                }
                command = Console.ReadLine();
            }

            if (names.Count > 0)
            {
                Console.WriteLine($"{string.Join(", ", names)} are going to the party!");
            }

            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static void MyAddRange(List<string> names, List<string> temp)
        {
            foreach (var currentName in temp)
            {
                int index = names.IndexOf(currentName);
                names.Insert(index, currentName);

            }
        }
    }
}
