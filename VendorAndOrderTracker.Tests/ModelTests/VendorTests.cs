using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class VendorTests: IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstancesOfVendor_Vendor()
    {
      string vendorName = "Starbucks";
      string vendorDescription = "Cafe";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);

      string resultName = newVendor.Name;
      string resultDescription = newVendor.Description;

      Assert.AreEqual(vendorName, resultName);
      Assert.AreEqual(vendorDescription, resultDescription);
    }
    [TestMethod]
    public void GetId_ReturnVendorId_Int()
    {
      string vendorName = "Starbucks";
      string vendorDescription = "Cafe";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      int idResult = newVendor.Id;
      Assert.AreEqual(1, idResult);
    }
    [TestMethod]
    public void GetAll_ReturnAllVendorObjects_VendorList()
    {
      string vendorName1 = "Starbucks";
      string vendorDescription1 = "Cafe";
      string vendorName2 = "Safeway";
      string vendorDescription2 = "Grocery Store";
      Vendor newVendor1 = new Vendor(vendorName1, vendorDescription1);
      Vendor newVendor2 = new Vendor(vendorName2, vendorDescription2);
      List<Vendor> newVendorList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> listResult = Vendor.GetAll();
      CollectionAssert.AreEqual(newVendorList, listResult);
    }
    [TestMethod]
    public void Find_ReturnCorrectVendor_Vendor()
    {
      string vendorName1 = "Starbucks";
      string vendorDescription1 = "Cafe";
      string vendorName2 = "Safeway";
      string vendorDescription2 = "Grocery Store";
      Vendor newVendor1 = new Vendor(vendorName1, vendorDescription1);
      Vendor newVendor2 = new Vendor(vendorName2, vendorDescription2);
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);

    }
  }
}