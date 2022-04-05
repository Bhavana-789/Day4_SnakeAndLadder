using System;

namespace Snake_and_ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder program");
            //UC3
            Console.WriteLine("Welcome to UC3 program");
            Console.WriteLine("Welcome to UC3 program");
            int Noplay = 0;
            int ladder = 1;
            int snake = 2;
            Random random = new Random();
            int randomCheck = random.Next(1, 3);
            Console.WriteLine("Checking for status" + randomCheck);
            if (randomCheck == ladder)
            {
                Random random2 = new Random();
                int Diceroll = random2.Next(1, 7);
                Console.WriteLine("You have moved forward by:" + Diceroll);
            }
            else if (randomCheck == snake)
            {
                Random rand2 = new Random();
                int Dice = rand2.Next(1, 7);
                Console.WriteLine("You went backward by:" + Dice);

            }
            else
            {
                Console.WriteLine("No play");
            }
        }
    }
}
