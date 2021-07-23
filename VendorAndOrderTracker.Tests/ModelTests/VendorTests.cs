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

      string result = newVendor.Name;

      Assert.AreEqual(vendorName, result);
    }
    // [TestMethod]
    // public void ()
    // {

    //   Assert.AreEqual();
    // }
  }
}