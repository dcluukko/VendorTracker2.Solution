using System.Collections.Generic;
using System;

namespace VendorTracker.Models
{
 public class Vendor
  {
   private static List<Vendor> _vendors = new List<Vendor> { };
   public string Name { get; set; }
   public int Id { get; }
   public List<Order> Orders { get; set; }
    public List<Order> Test { get; set; }
    public Vendor(string vendorType)
    {
    Name = vendorType;
    _vendors.Add(this);
    Id = _vendors.Count;
    Orders = new List<Order> { };

    }
      public static void ClearAll()
    {
      _vendors.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _vendors;
    }

    public static Vendor Find(int id)
    {
      return _vendors[id-1];
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  }
}