using System.Collections.Generic;
using System;

namespace VendorTracker.Models
{
 public class Vendor
  {
   public static List<Vendor> _vendors = new List<Vendor> { };
   public string Name { get; set; }
   public int Id { get; }
   public static List<Order> _test { get; set; }
   public static List<Order> Orders { get; set; }
  
    public Vendor(string name)
    {
    Name = name;
    _vendors.Add(this);
    Id = _vendors.Count;

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

    // public void AddOrder(Order Orders)
    // {
    //   Vendor.Add(Orders);
    // }
  }
}