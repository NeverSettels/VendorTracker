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
  }
}