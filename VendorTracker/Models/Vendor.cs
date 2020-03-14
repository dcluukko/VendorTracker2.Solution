using System.Collections.Generic;
using System;

namespace VendorTracker.Models
{
 public class Vendor
  {
   public static List<Vendor> _vendors = new List<Vendor> { };
   public string Name { get; set; }
   public int Id { get; }
  
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
  }
}