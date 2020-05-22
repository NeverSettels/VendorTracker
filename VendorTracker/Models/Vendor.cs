using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Vendor
  {
    public string Name {get;set;}
    public string Description {get;set;}
    public int Id  {get;}
    public List<Order> Orders {get;set}
    private static int _currentId = 0;
    private static List<Vendor> _instances = new List<Vendor> {};

    public Vendor(string name, string desc)
    {
      Name = name;
      Description=desc;
      Id=_currentId;
      _currentId++;
      _instances.Add(this);
    }
  }
}