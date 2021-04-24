using System;

namespace _5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine());
            string order = Console.ReadLine();
            do
            {
                if (order == "breakfast set")
                {
                    if (time > 11)
                    {
                        Console.WriteLine("Sorry your order is not available");
                    }
                    string a = Console.ReadLine();
                    string b = Console.ReadLine();
                    string c = Console.ReadLine();
                    string d = Console.ReadLine();
                    string e = Console.ReadLine();
                    if (e == "breakfast set")
                    {

                        Console.WriteLine("Sorry your order is out of stock");
                    }
                }
                else if (order == "weekend set")
                {
                    if (time > 11)
                    {
                        Console.WriteLine("Sorry your order is not available");
                    }
                    string a = Console.ReadLine();
                    string b = Console.ReadLine();
                    if (b == "breakfast set")
                    {

                        Console.WriteLine("Sorry your order is out of stock");
                    }
                }
                else if (order == "coffee")
                {
                    string a = Console.ReadLine();
                    string b = Console.ReadLine();
                    string c = Console.ReadLine();
                    if (c == "breakfast set")
                    {

                        Console.WriteLine("Sorry your order is out of stock");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid menu");
                }
            } while (order != "end");
        }
    }
}
