﻿using System;

namespace Snake_and_ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder program");
            //UC6
            Console.WriteLine("Welcome to UC6 program");
            int ladder = 1, ldice = 0;
            int snake = 2, sdice;
            int win = 100;
            int diceRoll = 0;
            int count = 0, a = 0;
            while (count != win)
            {
                if (count >= 0 && count < 100)
                {
                    Random random = new Random();
                    int randomCheck = random.Next(3);
                    diceRoll++;

                    switch (randomCheck)
                    {
                        case 1:
                            {
                                Console.WriteLine("Got Ladder");
                                Random rnd = new Random();
                                ldice = rnd.Next(1, 7);
                                count = count + ldice;
                                Console.WriteLine("Position is " + count);
                                a = count;
                                break;
                            }
                        case 2:
                            {
                                Random sran = new Random();
                                sdice = sran.Next(1, 7);
                                count = count - sdice;
                                Console.WriteLine("Position is: " + count);
                                Console.WriteLine("Got snake");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("No play");
                                Console.WriteLine("Position is: " + count);
                                break;
                            }
                    }
                }
                else if (a > 100)
                {
                    count = a - ldice;
                }
                else
                {
                    count = 0;
                }

            }
            Console.WriteLine("Player wins" + count);
            Console.WriteLine("Number of time Dice Roll is to win: " + diceRoll);

        }
    }
}

