namespace UserInput
{
    class UserInputClass
    {
        private static void UserInputMate()
        {
            // See https://aka.ms/new-console-template for more information

            /*
             * Do while example use case
            Random random = new Random();
            int current = 0;

            do
            {
                current = random.Next(1, 11);
                Console.WriteLine(current);
            } while (current != 7);

            */

            /*
             * While use case
            Random randomNumber = new Random();
            int current = randomNumber.Next(1, 11);

            while (current >= 3)
            {
                Console.WriteLine(current);
                current = randomNumber.Next(1, 11);
            }

            Console.WriteLine($"Last number: {current}");
            */
            /*
             * Example of using continue, notice how nothing greater than 8 gets logged out
             * However the loop still runs, unlike a break which sould stop the loop

            Random random = new Random();
            int current = random.Next(1, 11);

            do
            {
                current = random.Next(1, 11);

                if (current >= 8) continue;

                Console.WriteLine(current);
            } while (current != 7);

            */

            //  https://learn.microsoft.com/en-us/training/modules/csharp-do-while/3-challenge
            /*
             * A great interactive role based combat game!
            Random attack = new Random();
            string hero = "Aidan";
            string monster = "Bad Code";
            int heroHealth = 10;
            int monsterHealth = 10;



            do
            {
                int firstAttackDamage = attack.Next(1, 10);
                monsterHealth -= firstAttackDamage;
                Console.WriteLine($"{hero} just hit the {monster} for a {firstAttackDamage}, {monster} has {monsterHealth} remaining.");
                if ( monsterHealth <= 0 )
                {
                    Console.WriteLine($"The {monster} is dead and {hero} is the victor!!");
                } else
                {
                    int secondAttackDamage = attack.Next(1, 10);
                    heroHealth -= secondAttackDamage;
                    Console.WriteLine($"{monster} just hit {hero} for a {secondAttackDamage}, {hero} has {heroHealth}");
                    if (heroHealth <= 0)
                    {
                        Console.WriteLine($"Sadly {hero} took his last breath, the {monster} has struck him down...");
                    }
                }
            } while (heroHealth >= 0 && monsterHealth >= 0);
            */

            /*
             * Capture a string of greater than 3 chars
            string? readResult;
            bool validEntry = false;
            Console.WriteLine("Enter a string:");
            do
            {
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    if (readResult.Length >= 3)
                    {
                        validEntry = true;
                    }
                    else
                    {
                        Console.Write("Your entry is invalid");
                    }
                }
            } while (validEntry == false);

            Console.WriteLine(readResult);

            */

            string? readResult;
            string valueEntered = "";
            int numericValue = 0;
            bool validNumber = false;

            Console.WriteLine("Enter an int between 5 and 10");

            do
            {
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    valueEntered = readResult;
                }

                validNumber = int.TryParse(valueEntered, out numericValue);

                if (validNumber == true)
                {
                    if (numericValue <= 5 || numericValue >= 10)
                    {
                        validNumber = false;
                        Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10.");
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, you entered an invalid number, please try again");

                }
            } while (validNumber == false);

        }
    }
}

