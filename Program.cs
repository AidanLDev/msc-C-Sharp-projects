// See https://aka.ms/new-console-template for more information

Random coin = new Random();
int coinToss = coin.Next(0, 2);
Console.WriteLine($"Flipping coin... {(coinToss == 1 ? "Heads" : "Tails")}.");

// https://learn.microsoft.com/en-us/training/modules/csharp-code-blocks/2-exercise-variable-scope