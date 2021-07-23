using System;
using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }

    private static List<Order> _instances = new List<Order> { };

    public Order(string orderTitle, string orderDescription, int orderPrice, string orderDate)
    {
      Title = orderTitle;
      Description = orderDescription;
      Price = orderPrice;
      Date = orderDate;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}