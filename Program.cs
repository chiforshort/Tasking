using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;

namespace Tasking
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.ForegroundColor = ConsoleColor.Cyan;

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
            var menu = new EasyConsole.Menu();
            menu.Display();
        }

        private static bool MainMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to FloorMart. Choose the department you're looking for: ");
            Console.WriteLine("1. Groceries/Produce");
            Console.WriteLine("2. Electronics");
            Console.WriteLine("3. Clothing");
            Console.WriteLine("4. Toys");
            Console.WriteLine("5. Home Decor");
            Console.WriteLine("6. Pets");
            Console.WriteLine("7. Finished Shopping.");


            switch (Console.ReadLine())
            {
                case "1":
                    GroceriesProduce();
                    return true;
                case "2":
                    Electronic();
                    return true;
                case "3":
                    Clothing();
                    return true;
                case "4":
                    Toys();
                    return true;
                case "5":
                    HomeDecor();
                    return true;
                case "6":
                    Pets();
                    return true;
                case "7":
                    Done();
                    return false;
                default:
                    return true;


                 

            }
        }

        private static void Done()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Thank you for shopping with us!");
            Console.ReadLine();
            
            
        }

        private static void Pets()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("1. Add treats to basket");
            Console.WriteLine("2. Add toys to basket");
            Console.WriteLine("3. Return to department menu");
            string input = Console.ReadLine();
           
            if ((input) == "1")
            {
                Console.WriteLine("Treats have been added to basket");
                Console.Read();
                 
            }
            else if ((input) == "2")
            {
                Console.WriteLine("Toys have been added to basket");
                Console.Read();
                    
            }
            else if ((input) == "3")
            {
                Console.WriteLine("Returning to department menu");
                Console.Read();
                MainMenu();
            }
            else 
            {
                Console.WriteLine("Incorrect entry");
                   

            }



        }

        private static void HomeDecor()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("1. Add lamp to basket");
            Console.WriteLine("2. Add desk to basket");
            Console.WriteLine("Return to department menu");
            Console.ReadLine();
            string input = Console.ReadLine();

            if ((input) == "1")
            {
                Console.WriteLine("Lamp have been added to basket");
                Console.Read();

            }
            else if ((input) == "2")
            {
                Console.WriteLine("Desk have been added to basket");
                Console.Read();

            }
            else if ((input) == "3")
            {
                Console.WriteLine("Returning to department menu");
                Console.Read();
                MainMenu();
            }
            else
            {
                Console.WriteLine("Incorrect entry");


            }

        }

        private static void Toys()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("1. Add legos to basket");
            Console.WriteLine("2. Add yoyo to basket");
            Console.WriteLine("Return to department menu");
            Console.ReadLine();
            string input = Console.ReadLine();

            if ((input) == "1")
            {
                Console.WriteLine("Legos have been added to basket");
                Console.Read();

            }
            else if ((input) == "2")
            {
                Console.WriteLine("Yoyo have been added to basket");
                Console.Read();

            }
            else if ((input) == "3")
            {
                Console.WriteLine("Returning to department menu");
                Console.Read();
                MainMenu();
            }
            else
            {
                Console.WriteLine("Incorrect entry");


            }
        }

        private static void Clothing()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("1. Add shirt to basket");
            Console.WriteLine("2. Add pants to basket");
            Console.WriteLine("Return to department menu");
            Console.ReadLine();
            string input = Console.ReadLine();

            if ((input) == "1")
            {
                Console.WriteLine("Shirt have been added to basket");
                Console.Read();

            }
            else if ((input) == "2")
            {
                Console.WriteLine("Pants have been added to basket");
                Console.Read();

            }
            else if ((input) == "3")
            {
                Console.WriteLine("Returning to department menu");
                Console.Read();
                MainMenu();
            }
            else
            {
                Console.WriteLine("Incorrect entry");


            }
        }

        private static void Electronic()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("1. Add TV to basket");
            Console.WriteLine("2. Add PS4 to basket");
            Console.WriteLine("Return to department menu");
            Console.ReadLine();
            string input = Console.ReadLine();

            if ((input) == "1")
            {
                Console.WriteLine("TV have been added to basket");
                Console.Read();

            }
            else if ((input) == "2")
            {
                Console.WriteLine("PS4 have been added to basket");
                Console.Read();

            }
            else if ((input) == "3")
            {
                Console.WriteLine("Returning to department menu");
                Console.Read();
                MainMenu();
            }
            else
            {
                Console.WriteLine("Incorrect entry");


            }
        }

        private static void GroceriesProduce()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("1. Add lettuce to basket");
            Console.WriteLine("2. Add beef to basket");
            Console.WriteLine("Return to depepartment menu");
            Console.ReadLine();
            string input = Console.ReadLine();

            if ((input) == "1")
            {
                Console.WriteLine("Lettuce have been added to basket");
                Console.Read();

            }
            else if ((input) == "2")
            {
                Console.WriteLine("Beef have been added to basket");
                Console.Read();

            }
            else if ((input) == "3")
            {
                Console.WriteLine("Returning to department menu");
                Console.Read();
                MainMenu();
            }
            else
            {
                Console.WriteLine("Incorrect entry");


            }

        }
    }
}
