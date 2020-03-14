using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Order
  {
    public int Bread { get; set; }
    public int Pastry { get; set; }
    public int Id { get; }
    private static List<Order> _orders = new List<Order> { };
    public static List<Order> _test = new List<Order> { };
    public Order( int bread, int pastry)
    {
      Bread = bread;
      Pastry = pastry;
      _orders.Add(this);
      Id = _orders.Count;
    }

     public static List<Order> GetAll()
    {
      return _test;
    }
  }
}