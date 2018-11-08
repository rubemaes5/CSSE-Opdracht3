using System;
using System.Collections.Generic;
namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("jow");
            var drank = new(string, double)[]
            {
                ("plat water", 1),
                ("cola 25 cl", 1.5),
                ("cola 33cl", 2),
                ("witte wijn", 3),
                ("pils", 2),
                ("toast", 5),
                ("kaasplank", 4),
            };
            foreach(var item in drank){
                Console.WriteLine(item);
            }
            string[,] drinks = new string[7,3]{
                {"1", "plat water", "1"},
                {"2", "cola 25cl", "1.5"},
                {"3", "cola 33cl", "2"},
                {"4", "witte wijn", "3"},
                {"5", "pils", "2"},
                {"6", "toast", "5"},
                {"7", "kaasplank", "4"},
            };
            Console.WriteLine("enter itemNumber");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Number: "+drinks[number-1, 0]+" Drink: "+drinks[number-1, 1]+" kostprijs: €" + drinks[number-1, 2]);
        }
    }
}
