using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorTracker.Models
{
  public class VendorTest
  {
      [TestMethod]
    public void OrderConstructor_CreatesInstanceofOrder_Order()
    {
      Order newOrder = new Order(1,2);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    } 
  }
}