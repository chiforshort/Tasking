using System;

namespace EasyConsole
{
    internal class Menu
    {


        internal void Display()
        {

            Console.Clear();
            Console.WriteLine("Welcome to FloorMart. Choose the department you're looking for: ");
            Console.WriteLine("1. Groceries/Produce");
            Console.WriteLine("2. Electronics");
            Console.WriteLine("3. Clothing");
            Console.WriteLine("4. Toys");
            Console.WriteLine("5. Home Decor");
            Console.WriteLine("6. Pets");
            Console.WriteLine("7. Finished Shopping.");


        }
    }
}