using System;

namespace Snake_and_ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder program");
            //UC2
            Console.WriteLine("Welcome to UC2 program");
            Random random = new Random();
            int num = random.Next(1, 7);
            Console.WriteLine("The Random Dice Number is: " + num);

        }
    }
}
