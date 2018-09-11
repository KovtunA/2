using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the X coordinate ");
            int x = getNumber();
            Console.WriteLine("enter the Y coordinate ");
            int y = getNumber();

            if (x > 0)
            {
                if (y > 0)
                {
                    Console.WriteLine("Your point is in first quarter ");
                }
                else
                {
                    Console.WriteLine("Your point is in fourth quarter");
                }
            }
            else if (x < 0)
            {
                if (y > 0)
                {
                    Console.WriteLine("Your point is in second quarter");
                }
                else
                {
                    Console.WriteLine("Your point is in third quarter");
                }
            }
        }

        private static Int32 getNumber() 
        {             string userInput = Console.ReadLine();              try { return Convert.ToInt32(userInput); }             catch             {                 Console.WriteLine("Invalid input, please try again");                 return getNumber();             }
        }
    }
}