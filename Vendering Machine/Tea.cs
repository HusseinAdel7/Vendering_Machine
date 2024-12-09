using System;

namespace Vendering_Machine
{
    class Tea : Product
    {
        public Tea()
        {
            Name = "Tea";
            Cost = 1.50;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("\t\t\t\t   ┌──────────────────────────────┐");
            Console.WriteLine($"\t\t\t\t   │   You're Drink Is : {Name}      │\n\t\t\t\t   │    The Cost Is : {Cost}$\t  │");
            Console.WriteLine("\t\t\t\t   └──────────────────────────────┘");
            Console.WriteLine();
        }
    }
}
