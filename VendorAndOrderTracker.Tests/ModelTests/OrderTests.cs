using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class OrderTests: IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstancesOfAnOrder_Order()
    {
      string orderTitle = "Starbucks needs some pastries!";
      string orderDescription = "3 pastries";
      int orderPrice = 5;
      string orderDate = "07/24/2021";
      Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);

      string resultTitle = newOrder.Title;
      string resultDescription = newOrder.Description;
      int resultPrice = newOrder.Price;
      string resultDate = newOrder.Date;

      Assert.AreEqual(orderTitle, resultTitle);
      Assert.AreEqual(orderDescription, resultDescription);
      Assert.AreEqual(orderPrice, resultPrice);
      Assert.AreEqual(orderDate, resultDate);
    }
  }
}