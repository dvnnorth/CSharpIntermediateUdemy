using System.Linq;

namespace Methods
{
  public class Calculator
  {
    public static int Add(params int[] numbers)
    {
      return numbers.Aggregate((x, y) => x + y);
    }
  }
}
