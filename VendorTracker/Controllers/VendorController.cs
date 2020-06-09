using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;

namespace VendorTracker.Controllers
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
    public ActionResult Create(string name, string desc)
    {
      Vendor newVendor = new Vendor(name,desc);
      return RedirectToAction("Index");
    }
    
    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Vendor foundV = Vendor.Find(id);
      return View(foundV);
    }
  
   [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string name, string desc, int price, string dd)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(name,desc,price,dd);
      foundVendor.Orders.Add(newOrder); 
      List<Order> VendorOrders = foundVendor.Orders;
      model.Add("orders", VendorOrders);
      model.Add("vendor", foundVendor);
      return View("Show", model);
    }
}
}