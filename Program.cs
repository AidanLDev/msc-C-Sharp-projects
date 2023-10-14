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


