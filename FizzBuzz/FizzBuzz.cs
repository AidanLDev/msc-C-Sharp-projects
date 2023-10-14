using System;

namespace fizzBuzz
{
    class fizzBuzzLoop
    {
        private static void FizzBuzzClass()
        {
            for (int i = 1; i <= 100; i++)
            {
                string fizz = i % 3 == 0 ? "Fizz" : "";
                string buzz = i % 5 == 0 ? "Buzz" : "";
                Console.WriteLine($"{i} {fizz}{buzz}");
            }
        }
    }
}