using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorTracker.TestTools
{
  [TestClass]
  public class VendorTest : IDisposable
  {
     public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceofVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    } 

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Petunias";
      Vendor newVendor = new Vendor(name);
      //Act
      string compare = newVendor.Name;
      //Assert
      Assert.AreEqual(name, compare);

    }
    [TestMethod]
    public void GetId_ReturnId_Int()
    {
      //Arrange
      Vendor newVendor = new Vendor("test");
      //Act
      int compare = newVendor.Id;
      //Assert
      Assert.AreEqual(1, compare);
    }
    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      //Arrange
      Vendor newVendor1 = new Vendor("string1");
      Vendor newVendor2 = new Vendor("string2");

      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      //Act
      List<Vendor> compareList = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, compareList);
    }
    [TestMethod]
    public void Find_ReturnsCorrectVendorWithId_Vendor()
    {
      //Arrange
      Vendor newVendor1 = new Vendor("string1");
      Vendor newVendor2 = new Vendor("string2");

      //Act
      Vendor compare = Vendor.Find(1);

      //Assert
      Assert.AreEqual(newVendor1, compare);
    }
    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      //Arrange
      Order newOrder = new Order(1,2);
      List<Order> newList = new List<Order> { newOrder };
      Vendor newVendor = new Vendor("title");
      newVendor.AddOrder(newOrder);
      //Act

      List<Order> result = newVendor.Orders;

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
    
  }
}