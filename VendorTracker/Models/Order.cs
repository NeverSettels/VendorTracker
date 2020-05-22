using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Order
  {
    public string Name {get;set;}
    public string Description {get;set;}
    public int Price {get;set;}
    public string DeliveryDate {get;set;}
     public int Id  {get;}
   private static List<Order>  _instances = new List<Order> {};
    private static int _currentId = 0;


    public Order()
    {
    }
  }
}