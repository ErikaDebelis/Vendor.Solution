﻿using System;
using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> { };
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    
    public List<Order> Orders { get; set; }

    public Vendor(string vendorName, string vendorDescription)
    {
      Name = vendorName;
      Description = vendorDescription;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}