using System;

namespace Vendering_Machine
{
    class BlackCoffee : Product
    {
        public BlackCoffee()
        {
            Name = "Black Coffee";
            Cost = 2.00;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("\t\t\t\t   ┌───────────────────────────────────┐");
            Console.WriteLine($"\t\t\t\t   │   You're Drink Is : {Name}  │\n\t\t\t\t   │         The Cost Is : {Cost}$\t       │");
            Console.WriteLine("\t\t\t\t   └───────────────────────────────────┘");
            Console.WriteLine();
        }
    }
}
