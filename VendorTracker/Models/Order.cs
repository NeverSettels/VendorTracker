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


    public Order(string name, string desc, int price, string dd)
    {
         Name = name;
      Description=desc;
      Price = price;
      DeliveryDate =dd; 
      Id=_currentId;
      _currentId++;
      _instances.Add(this);
    }
     public static List<Order> GetAll()
    {
    
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId];
    }

  }
}
  }
}