using System;

namespace HiBenji
{
    class Program
    {
        static void Main(string[] args)
        {
            string response = "";
            Console.WriteLine("Welcome Benji!");
            do
            {
                Console.Write("What do you want to say? ");
                string what = Console.ReadLine();
                Console.Write("How many times? ");
                try
                {
                    int numberOfTimes = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= numberOfTimes; i++)
                    {
                        Console.WriteLine(i + ". " + what);
                    }
                    Console.WriteLine("Do you want to write something else?");
                    response = Console.ReadLine().ToLowerInvariant();
                    Console.Clear();
                }
                catch (Exception e)
                { Console.WriteLine("mistake"); }
            } while (response.Substring(0, 1) == "y");
            
        }
    }
}
