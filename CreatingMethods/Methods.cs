namespace Methods
{
  class MethodsClass
  {
    private static void MethodStuff()
    {
      /*
      // Example of optional params
      void DisplayNames(string firstName, string lastName = "Lowson")
      {
        Console.WriteLine($"{firstName} {lastName}");
      }
      DisplayNames("Arni", lastName: "Riani");
      */

      double total = 0;
      double minimumSpend = 30.00;

      double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
      double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };

      for (int i = 0; i < items.Length; i++)
      {
        total += GetDiscountedPrice(i);
      }

      if (TotalMeetsMinimum())
      {
        total -= 5.00;
      }

      Console.WriteLine($"Total: ${FormatDecimal(total)}");

      double GetDiscountedPrice(int itemIndex)
      {
        // Calculate the discounted price of the item
        return items[itemIndex] * (1 - discounts[itemIndex]);
      }

      bool TotalMeetsMinimum()
      {
        return total >= minimumSpend;
      }

      string FormatDecimal(double input)
      {
        return input.ToString().Substring(0, 5);
      }
    }
  }
}