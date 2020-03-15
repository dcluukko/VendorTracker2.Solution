using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorTracker.TestTools
{
  [TestClass]
  public class OrderTest : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
    [TestMethod]
    public void OrderConstructor_CreatesInstanceofOrder_Order()
    {
      Order newOrder = new Order(1,2);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    } 
    [TestMethod]
    public void GetId_ReturnId_Int()
    {
      //Arrange
      Order newOrder = new Order(1,2);
      //Act
      int compare = newOrder.Id;
      //Assert
      Assert.AreEqual(1, compare);
    }
    [TestMethod]
    public void GetAll_ReturnsAllOrderObjects_OrderList()
    {
      //Arrange
      Order newOrder1 = new Order(1, 2);
      Order newOrder2 = new Order(1, 2);

      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      //Act
      List<Order> compareList = Order.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, compareList);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrderWithId_Order()
    {
      //Arrange
      Order newOrder1 = new Order(1, 2);
      Order newOrder2 = new Order(1, 2);

      //Act
      Order compare = Order.Find(1);

      //Assert
      Assert.AreEqual(newOrder1, compare);
    }
  }
} 