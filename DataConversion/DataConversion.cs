namespace DataConverting
{
  class OrganisingStrings
  {
    private static void organisingStringData()
    {
      string[] values = { "12.3", "45", "ABC", "11", "DEF" };
      string formMessage = "";
      decimal total = 0;
      foreach (string value in values)
      {
        decimal number;
        if (decimal.TryParse(value, out number))
        {
          total += number;
        }
        else
        {
          formMessage += value;
        }
      }
      Console.WriteLine($"Message: {formMessage}");
      Console.WriteLine($"Total: {total}");
    }
  }
}