using System.Collections.Generic;
using System;

namespace CarDealership.Models
{
  public class Car
  {
    private string _makeModel;
    private int _price;
    private int _mileage;
    private static List<Car> _instances = new List<Car> {};

    public Car (string makeModel, int price, int mileage)
    {
      _makeModel = makeModel;
      _price = price;
      _mileage = mileage;
    }

    public string GetMakeModel()
    {
      return _makeModel;
    }

    public void SetMakeModel(string makeModel)
    {
      _makeModel = makeModel;
    }

    public int GetPrice()
    {
      return _price;
    }

    public void SetPrice(int price)
    {
      _price = price;
    }

    public int GetMileage()
    {
      return _mileage;
    }

    public void SetMilage(int mileage)
    {
      _mileage = mileage;
    }

    public void Save()
    {
      _instances.Add(this);
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }

        public static void ClearAll()
    {
      _instances.Clear();
    }
  }

}
