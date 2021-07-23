using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorAndOrderTracker.Models;

namespace VendorAndOrderTracker.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orderList/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }
    [HttpGet("/vendors/{vendorId}/orderList/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order newOrder = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", newOrder);
      model.Add("vendor", vendor);
      return View(model);
    }
  }
}