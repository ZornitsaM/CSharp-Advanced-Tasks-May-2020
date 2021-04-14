using System;
using System.Linq;
using System.Collections.Generic;

namespace Threeuple
{
    public class StartUp
    {
       public static void Main(string[] args)
        {
            var inputInfo = Console.ReadLine().Split();
            var inputBeers = Console.ReadLine().Split();
            var inputBank = Console.ReadLine().Split();

            string fullName = inputInfo[0] + " " + inputInfo[1];
            string adress = inputInfo[2];
            string cityFullName = string.Join(" ", inputInfo.Skip(3));

            string name = inputBeers[0];
            int litters = int.Parse(inputBeers[1]);
            string drinkOrNot = inputBeers[2];
            if (drinkOrNot=="drunk")
            {
                drinkOrNot = "True";
            }
            else
            {
                drinkOrNot = "False";
            }

            string nameBank = inputBank[0];
            double accountBalance = double.Parse(inputBank[1]);
            string bankName = inputBank[2];

            var firstInfo = new Threeuple<string, string, string>(fullName, adress, cityFullName);
            var secondInfo = new Threeuple<string, int, string>(name, litters, drinkOrNot);
            var thirdInfo = new Threeuple<string, double, string>(nameBank, accountBalance, bankName);

            Console.WriteLine(firstInfo.ToString());
            Console.WriteLine(secondInfo.ToString());
            Console.WriteLine(thirdInfo.ToString());
        }
    }
}
