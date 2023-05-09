using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Car
  {
    public string MakeModel { get; set; }
    public int Price { get; set; }
    
    private static Dictionary<string, int> _carList = new Dictionary<string, int>() {};

    public Car(string makeModel, int price)
    {
      MakeModel = makeModel;
      _carList.Add(makeModel, price);
    }

    public static Dictionary<string, int> GetAll()
    {
      return _carList;
    }

    public static void ClearAll()
    {
      _carList.Clear();
    }
  }
}
