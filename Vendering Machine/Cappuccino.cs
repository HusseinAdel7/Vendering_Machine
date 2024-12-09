using System;

namespace Vendering_Machine
{
    class Cappuccino : Product
    {
        public Cappuccino()
        {
            Name = "Cappuccino";
            Cost = 3.00;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("\t\t\t\t   ┌───────────────────────────────────┐");
            Console.WriteLine($"\t\t\t\t   │   You're Drink Is : {Name}    │\n\t\t\t\t   │         The Cost Is : {Cost}$\t       │");
            Console.WriteLine("\t\t\t\t   └───────────────────────────────────┘");
            Console.WriteLine();
        }
    }
}
