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
  }
}