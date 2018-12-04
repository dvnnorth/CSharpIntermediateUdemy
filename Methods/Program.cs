using System;

namespace Methods
{
  class Program
  {
    static void Main(string[] args)
    {
      try
      {
        var point = new Point(10, 20);
        point.Move(new Point(14, 16));
        point.Move(300, 100);
        point.Move(null);
        Console.WriteLine(point.X);
        Console.WriteLine(point.Y);
      }
      catch (System.Exception exception)
      {
        Console.WriteLine($"An unexpected error has occured. {exception}");
      }
      Console.WriteLine("This should still happen! The code has not been stopped.");
      Console.WriteLine(Calculator.Add(1, 2, 3, 4, 5, 6, 7));

      // out modifier -> Don't use it unless you have to

      // var number  = int.Parse("abc"); Doesn't work, throws exception

      int number;
      var result = int.TryParse("abc", out number);
      Console.WriteLine(result);
      Console.WriteLine(number);
      var result2 = int.TryParse("1383849", out number);
      Console.WriteLine(result2);
      Console.WriteLine(number);
    }
  }
}
