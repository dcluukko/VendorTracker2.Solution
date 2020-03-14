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
      Vendor newVendor = new Vendor("");
      //Act
      int compare = newVendor.Id;
      //Assert
      Assert.AreEqual(1, compare);
    }
  }
}