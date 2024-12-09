using System;
using System.Xml.Linq;

namespace Vendering_Machine
{
    // Implement the VendingMachine class using the IVendingMachine interface
    class VendingMachine : IVendingMachine
    {

        #region Private Member Fields

        static double _moneyMachine = 0.0;     //Contains Money in the machine untill now
        static string _reportProblems = "";   //Contains reports that the technical support has reported
        static int _numberOfOrdersUntileThisMoment = 0;  //Contains Number of oreders from customers untill now

        #endregion


        #region Propreties ( To read Money in The Machine And Number Of Orders )

        public double monyMachine
        {
            get { return _moneyMachine; }
        }

        public int NuumberOfOrdersUntileThisMoment
        {
            get { return _numberOfOrdersUntileThisMoment; }
        }

        #endregion


        #region Constractors

        //Default Constractor
        public VendingMachine()
        {
        }

        // Constractor For Depostiting Money in The Machine
        public VendingMachine(double money)
        {
            if (money <= 100000)
            {
                if (money > 0.0)
                {
                    _moneyMachine += (double)money;
                    Done();
                }
                else if (money == 0.0)
                {
                    Console.WriteLine($"\n\t  Sorry, You Didn't Deposite Money !!");
                }
                else
                {
                    Console.WriteLine($"\n\t  Sorry, You Entered a Negative Value (Not Logic For Money) !!");
                }
            }
            else
            {
                Console.WriteLine($"\n\t  Sorry, You Can't deposite more than 100000 !!");

            }

        }

        // Constractor For Windrow From The Machine
        public VendingMachine(string s, double money)
        {
            if (money < _moneyMachine)
            {
                if (money > 0.0)
                {
                    _moneyMachine -= (double)money;
                    Done();
                }
                else if (money == 0.0)
                {
                    Console.WriteLine($"\n\t  Sorry, You Didn't Windrow Money !!");
                }
                else
                {
                    Console.WriteLine($"\n\t  Sorry, You Entered a Negative Value (Not Logic For Money) !!");
                }

            }
            else
            {
                Console.WriteLine($"\n\t  Sorry, Money in The Machine Doesn't Enoght To Windrow !!");
                Console.WriteLine($"\t  You Must windrow  less than or Equal To {_moneyMachine} !!");

            }

        }

        // Constractor For Showing The Reports
        public VendingMachine(string s)
        {
            _reportProblems += s;
            Done();
        }

        #endregion


        #region Methods

        // Function To Show The Products in The Machine 
        public void ShowProducts()
        {
            Console.WriteLine("\n  1. Latte");
            Console.WriteLine("\n  2. Cappuccino");
            Console.WriteLine("\n  3. Black Coffee");
            Console.WriteLine("\n  4. Tea");
        }

        // Function To Select a Product From The Products 
        public Product SelectProduct(int choice)
        {
            switch (choice)
            {
                case 1:
                    return new Latte();
                case 2:
                    return new Cappuccino();
                case 3:
                    return new BlackCoffee();
                case 4:
                    return new Tea();
                default:
                    return null;
            }
        }

        // Function To Check The Money IF Accepts Or Not
        public void AcceptPayment(double cost)
        {
            double totalPayment = 0;

            while (totalPayment < cost)
            {
                Console.Write($"   You Payed : {totalPayment:F2}$  ||  ");
                Console.Write("Please insert more money : ");
                double payment = double.Parse(Console.ReadLine());

                if (payment <= 0)
                {
                    Console.WriteLine("Invalid payment amount.");
                    continue;
                }
                totalPayment += payment;
                _moneyMachine += payment;
            }
            if (totalPayment > cost)
            {
                double change = totalPayment - cost;
                Console.WriteLine("\t\t\t   ┌──────────────────────────────────────┐");
                Console.WriteLine($"\t\t\t   │ Payment accepted. Your change: ${change:F2} │");
                Console.WriteLine("\t\t\t   └──────────────────────────────────────┘");
                _numberOfOrdersUntileThisMoment++;
            }
            else
            {
                Console.WriteLine("\t\t\t\t   ┌──────────────────┐");
                Console.WriteLine($"\t\t\t\t   │ Payment accepted │");
                Console.WriteLine("\t\t\t\t   └──────────────────┘");
                _numberOfOrdersUntileThisMoment++;
            }
        }

        // Function To Release The Choosen Product
        public void ReleaseItem(Product product)
        {
            Console.WriteLine("\t\t\t   ┌──────────────────────────────────────┐");
            Console.WriteLine($"\t\t\t     Thank You ! Here is your {product.Name} ");
            Console.WriteLine("\t\t\t   └──────────────────────────────────────┘");
        }

        // Function To Show Money in The Machine 
        public void ShowMony()
        {
            Console.WriteLine("\t\t\t   ┌────────────────────────────────────┐");
            Console.WriteLine($"\t\t\t     Your Mony in The Machine Is :  {_moneyMachine} ");
            Console.WriteLine("\t\t\t   └────────────────────────────────────┘");
        }

        // Function To Show Reports From The Technical Supports
        public void ShowReport()
        {
            Console.WriteLine($"\n     The Report Is  :   {_reportProblems} ");
        }

        // Function To Print "Done" Statement
        private void Done()
        {
            Console.WriteLine("\n\t\t\t   ┌──────┐");
            Console.WriteLine($"\t\t\t     Done");
            Console.WriteLine("\t\t\t   └──────┘");
        }

        #endregion


    }
}
