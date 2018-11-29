using System;

namespace ObjectInitializers
{
  class Program
  {
    static void Main(string[] args)
    {
      var john = new Person()
      {
        Name = "John",
        Id = 1
      };
      
      Console.WriteLine(john.Name);
      Console.WriteLine(john.Id);
    }
  }
}