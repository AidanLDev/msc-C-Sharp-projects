namespace ReverseSplitArrMainSpace
{
  class ReverseSplitArrClass
  {
    private static void ArrStuff()
    {
      /*
        string pangram = "The quick brown fox jumps over the lazy dog";

        string[] message = pangram.Split(' ');

        string[] newMessage = new string[message.Length];

        for (int i = 0; i < message.Length; i++)
        {
          char[] letters = message[i].ToCharArray();
          Array.Reverse(letters);
          newMessage[i] = new string(letters);
        }

        string result = String.Join(" ", newMessage);
      */

      string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

      string[] splitOrders = orderStream.Split(',');
      Array.Sort(splitOrders);

      for (int i = 0; i < splitOrders.Length; i++)
      {
        if (splitOrders[i].Length != 4)
        {
          Console.WriteLine($"{splitOrders[i]}\t - Error");
        }
        else
        {
          Console.WriteLine($"{splitOrders[i]}");
        }
      }
    }
  }
}