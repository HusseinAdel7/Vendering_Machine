using System;

namespace Vendering_Machine
{
    class Latte : Product
    {
        public Latte()
        {
            Name = "Latte";
            Cost = 2.50;
        }

        public override void DisplayInfo()
        {
         
            Console.WriteLine($"\n\t\t\t      You're Drink Is : {Name}\n\t\t\t        The Cost Is : {Cost}$\t  ");
            Console.WriteLine("\t\t\t   ──────────────────────────────");
            Console.WriteLine();

        }
    }
}
