using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorAndOrderTracker.Models;
using System;

namespace VendorAndOrderTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }
    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      return RedirectToAction("Index");
    }
    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> vendorOrders = selectedVendor.OrderList;
      model.Add("vendor", selectedVendor);
      model.Add("orderList", vendorOrders);
      return View(model);
    }
    [HttpPost("/vendors/{vendorId}/orderList")]
    public ActionResult Create(int vendorId, string orderTitle, string orderDescription, int orderPrice, string orderDate)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor vendorFound = Vendor.Find(vendorId);
      Order newOrderCreated = new Order(orderTitle, orderDescription, orderPrice, orderDate);
      vendorFound.AddOrder(newOrderCreated);
      List<Order> vendorOrders = vendorFound.OrderList;
      model.Add("orderList", vendorOrders);
      model.Add("vendor", vendorFound);
      return View("Show", model);
    }
  }
}