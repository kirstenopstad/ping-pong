using System;

class PingPong
{
  static void Main()
    {
      Console.WriteLine("Input a positive, whole number.");
      string stringUserNumber = Console.ReadLine();
      int userNumber = int.Parse(stringUserNumber);
      Console.WriteLine("You entered " + userNumber);
      // When user inputs a number less than 1, prompt again until input is > 1
      if (userNumber < 1)
      {
        Main();
      }
      // When user inputs positive number, print numbers in order up to user input
      for (int i = 1; i <= userNumber; i++)
      {
        // Else If number is % 5 == 0 || number % 3 == 0, print string ping-pong
        
        if (i % 3 == 0 && i % 5 == 0)
        {
          Console.WriteLine("ping-pong");
        }
        // If number is % 3 == 0, print string ping
        else if (i % 3 == 0)
        {
          Console.WriteLine("ping");
        }
        // Else If number is % 5 == 0, print string pong
        else if (i % 5 == 0)
        {
          Console.WriteLine("pong");
        }
              
        // Else, print number
        else
        {
          Console.WriteLine(i);
        }
      }
    }
}
