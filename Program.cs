// See https://aka.ms/new-console-template for more information
// https://learn.microsoft.com/en-us/training/modules/csharp-for/3-challenge

string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    if (names[i] == "Eddie") names[i] = "Steady";
    Console.WriteLine(names[i]);
}

for (int i = 0; i < names.Length; i++)
{
    int displayNum = i + 1;
    Console.WriteLine(displayNum + ": " + names[i]);
}