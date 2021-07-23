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

    [TestMethod]
    public void GetId_ReturnOrderId_Int()
    {
      string orderTitle = "Starbucks needs some pastries!";
      string orderDescription = "3 pastries";
      int orderPrice = 5;
      string orderDate = "07/24/2021";
      Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);

      int orderIdResult = newOrder.Id;

      Assert.AreEqual(1, orderIdResult);
    }

    [TestMethod]
    public void GetAll_ReturnAllOrderObjects_OrderList()
    {
      string orderTitle1 = "Starbucks needs some pastries!";
      string orderDescription1 = "3 pastries";
      int orderPrice1 = 5;
      string orderDate1 = "07/24/2021";

      string orderTitle2 = "Safeway needs some bread!";
      string orderDescription2 = "3 loaves of bread";
      int orderPrice2 = 10;
      string orderDate2 = "08/04/2021";
      
      Order newOrder1 = new Order(orderTitle1, orderDescription1, orderPrice1, orderDate1);
      Order newOrder2 = new Order(orderTitle2, orderDescription2, orderPrice2, orderDate2);
      List<Order> newOrderList = new List<Order> { newOrder1, newOrder2 };
      List<Order> listResult = Order.GetAll();

      CollectionAssert.AreEqual(newOrderList, listResult);
    }

    [TestMethod]
    public void AddOrder_AddOrderWithVendorAttached_OrderList()
    {
      //1st vendor
      string vendorName1 = "Starbucks";
      string vendorDescription1 = "Cafe";
      Vendor newVendor1 = new Vendor(vendorName1, vendorDescription1);
      //1st vendor's order input
      string orderTitle1 = "Starbucks needs some pastries!";
      string orderDescription1 = "3 pastries";
      int orderPrice1 = 5;
      string orderDate1 = "07/24/2021";
      Order newOrder1 = new Order(orderTitle1, orderDescription1, orderPrice1, orderDate1);
      //2nd vendor
      string vendorName2 = "Safeway";
      string vendorDescription2 = "Grocery Store";
      Vendor newVendor2 = new Vendor(vendorName2, vendorDescription2);
      //2nd vendor's order input
      string orderTitle2 = "Safeway needs some bread!";
      string orderDescription2 = "3 loaves of bread";
      int orderPrice2 = 10;
      string orderDate2 = "08/04/2021";
      Order newOrder2 = new Order(orderTitle2, orderDescription2, orderPrice2, orderDate2);

      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

        [TestMethod]
    public void Find_ReturnCorrectOrder_Order()
    {
      //1st vendor
      string vendorName1 = "Starbucks";
      string vendorDescription1 = "Cafe";
      Vendor newVendor1 = new Vendor(vendorName1, vendorDescription1);
      //1st vendor's order input
      string orderTitle1 = "Starbucks needs some pastries!";
      string orderDescription1 = "3 pastries";
      int orderPrice1 = 5;
      string orderDate1 = "07/24/2021";
      Order newOrder1 = new Order(orderTitle1, orderDescription1, orderPrice1, orderDate1);
      //2nd vendor
      string vendorName2 = "Safeway";
      string vendorDescription2 = "Grocery Store";
      Vendor newVendor2 = new Vendor(vendorName2, vendorDescription2);
      //2nd vendor's order input
      string orderTitle2 = "Safeway needs some bread!";
      string orderDescription2 = "3 loaves of bread";
      int orderPrice2 = 10;
      string orderDate2 = "08/04/2021";
      Order newOrder2 = new Order(orderTitle2, orderDescription2, orderPrice2, orderDate2);

      Order result = Order.Find(2);
      Assert.AreEqual(newOrder2, result);

    }
  }
}