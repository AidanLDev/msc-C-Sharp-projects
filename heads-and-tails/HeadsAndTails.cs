// See https://aka.ms/new-console-template for more information
using System;

namespace headsAndTails
{
    class coinToss
    {
        static void HeadsnTails()
        {
            Random coin = new Random();
            int coinToss = coin.Next(1, 3);
            Console.WriteLine($"Flipping coin... {(coinToss == 1 ? "Heads" : "Tails")}.");
        }

    }

}


