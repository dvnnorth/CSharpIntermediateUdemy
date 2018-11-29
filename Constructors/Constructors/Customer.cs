using System.Collections.Generic;

namespace Constructors
{
  public class Customer
  {
    // Do not declare fields public (need getters/setters). Taking this step by step
    public int Id;
    public string Name;
    public List<Order> Orders;

    public Customer()
    {
      Orders = new List<Order>();
    }

    public Customer(int id)
      //  : this() at this point means that the default constructor is called
      : this()
    {
      this.Id = id;
    }

    public Customer(int id, string name)
      // You can also call other constructors
      : this(id)
    {
      this.Name = name;
    }
  }
}