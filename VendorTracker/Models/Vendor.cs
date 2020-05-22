using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Vendor
  {
    public string Name {get;set;}
    public string Description {get;set;}
    public int Id  {get;}
    private static int _currentId = 0;
    private static List<Vendor> _instances = new List<Vendor> {};
  }
}