using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Xml.Linq;

namespace Vendering_Machine
{

    

    class Program
    {
        public static void clear()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t┌───────────────────────────────────┐");
            Console.WriteLine($"\t\t\t\t│   Welcome to the Vending Machine! │");
            Console.WriteLine("\t\t\t\t└───────────────────────────────────┘");
            Console.WriteLine(" *********************************************************************************************");

        }
        static void Main(string[] args)
        {
           
            while (true)
            {
                clear();
                Console.WriteLine("\n   1- Customer ");
                Console.WriteLine("\n   2- Techincal Support ");
                Console.WriteLine("\n   3- Admin ");

                Console.Write("\n  Please Choose (1-3): ");
                int c = int.Parse(Console.ReadLine());

                if (c == 1) 
                {
                    clear();
                    VendingMachine vendingMachine = new VendingMachine();
                    vendingMachine.ShowProducts();
                    Console.Write("\n  Please select a product (1-4): ");
                    int choice = int.Parse(Console.ReadLine());
                    clear();
                    Product selectedProduct = vendingMachine.SelectProduct(choice);
                    if (selectedProduct != null)
                    {
                        selectedProduct.DisplayInfo();
                        vendingMachine.AcceptPayment(selectedProduct.Cost);
                        vendingMachine.ReleaseItem(selectedProduct);
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice.");
                    }
                }
                else if (c == 2)
                {
                    clear();
                    Console.Write("\n   * Please Write a Report For The Problem : ");
                    string repo = Console.ReadLine();
                    VendingMachine vendingMachine = new VendingMachine(repo);

                }
                else if (c == 3)
                {
                    clear();
                    Console.Write("\n   Enter Username : ");
                    string username = Console.ReadLine();
                    Console.Write("\n   Enter Password : ");
                    string pass = Console.ReadLine();

                    if (username == "" && pass == "")
                    {
                        clear();
                        Console.WriteLine("\n   1 -Check Money");
                        Console.WriteLine("\n   2 -Deposite Money");
                        Console.WriteLine("\n   3 -Windrow Money");
                        Console.WriteLine("\n   4 -Check Rop Problems");
                        Console.WriteLine("\n   5 -Show Number Of Orders");


                        Console.Write("\n  Please select (1-4) : ");
                        int r = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n");
                        if (r == 1)
                        {
                            VendingMachine vendingMachine = new VendingMachine();
                            vendingMachine.ShowMony();
                        }
                        else if (r == 2)

                        {
                            clear();
                            Console.WriteLine("\n\t\t\t\t   ┌─────────────────┐");
                            Console.WriteLine($"\t\t\t\t   │ Depositing Mony │");
                            Console.WriteLine("\t\t\t\t   └─────────────────┘");
                            Console.WriteLine();
                            Console.Write("\n   * Note ==>  The Max Money That You Can Deposite Is 100000 ");
                            Console.Write("\n\n   * Enter The Mount of Money That You Wanna Deposite : ");
                            double mon = double.Parse(Console.ReadLine());
                            VendingMachine vendingMachine = new VendingMachine(mon);
                        }
                        else if (r == 3)
                        {
                            clear();
                            Console.WriteLine("\n\t\t\t\t   ┌─────────────────┐");
                            Console.WriteLine($"\t\t\t\t   │ Windrow Mony   │");
                            Console.WriteLine("\t\t\t\t   └─────────────────┘");
                            Console.WriteLine();
                            VendingMachine vendingMachine1 = new VendingMachine();
                            double mon = vendingMachine1.monyMachine;
                            if (mon == 0)
                            {
                                Console.Write($"\n   * Sorry, The Machine Doesn't Have Money ");

                            }
                            else
                            {
                                Console.Write($"\n   * Note ==>  Your Windrow Must Be Less Than {vendingMachine1.monyMachine} ");
                                Console.Write("\n   * Enter The Mount of Money That You Wanna Windrow : ");
                                double mon2 = double.Parse(Console.ReadLine());
                                VendingMachine vendingMachine = new VendingMachine("wind", mon2);
                            }
                            
                        }
                        else if (r == 4)
                        {
                            VendingMachine vendingMachine = new VendingMachine();
                            vendingMachine.ShowReport();
                        }
                        else if (r == 5)
                        {
                            VendingMachine vendingMachine = new VendingMachine();
                            Console.Write($"   * Number Of Orders Untill Now Are  :  {vendingMachine.NuumberOfOrdersUntileThisMoment}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice.");
                        }
                    }
                    else
                    {
                        Console.Write("Username Or Password Invalid");
                    }
                }
                else
                {
                    Console.WriteLine("Not Valid");
                }

                Thread.Sleep(3000);
                Console.Clear();

            }
            
            
        }
    }
}
