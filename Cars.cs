using System;
using System.Collections.Generic;

class Car
{
  private string _makeModel;
  private int _price;
  private int _miles;

  //this is the constructor
  public Car(string automobileMake, int automobilePrice, int automobileMiles)
  {
    _makeModel = automobileMake;
    _price = automobilePrice;
    _miles = automobileMiles;
  }

    public void SetMake(string newMake)
    {
      _makeModel = newMake;
    }
    public string GetMake()
    {
      return _makeModel;
    }
    public void SetPrice(int newPrice)
    {
      if (newPrice >= 0) {
        _price = newPrice;
      }
      else {
        Console.WriteLine("The price for this item is not valid.");
      }
    }

    public int GetPrice()
    {
      return _price;
    }
    public void SetMiles(int newMiles)
    {
      _miles = newMiles;
    }
    public int GetMiles()
    {
      return _miles;
    }

    public bool MaxPrice(int maximumPossiblePrice)
    {
      if (_price <= maximumPossiblePrice)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public bool MaxMiles(int totalAcceptableMiles)
    {
      if (_miles <= totalAcceptableMiles)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

  }

public class Program
{
  public static void Main()
  {
    Car porsche = new Car("2014 Porsche 911", 114991, 7864);
    Car ford = new Car("2011 Ford F450", 55995, 14241);
    Car lexus = new Car("2013 Lexus RX 350", 44700, 20000);
    Car mercedes = new Car("Mercedes Benz CLS550", 39900, 37979);

    List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes };

    Console.WriteLine("What is your max price?");
    string stringPrice = Console.ReadLine();
    int userPrice = int.Parse(stringPrice);
    // userCar.Price = userPrice;

    Console.WriteLine("What is your max mileage?");
    string stringMiles = Console.ReadLine();
    int userMiles = int.Parse(stringMiles);
    // userCar.Miles = userMiles;

    List<Car> CarsMatchingSearch = new List<Car>();
    // Car userCar = new Car();

    foreach (Car currentCar in Cars)
    {
      if (currentCar.MaxPrice(userPrice) &&
          currentCar.MaxMiles(userMiles))
      {
        CarsMatchingSearch.Add(currentCar);
      }
    }

    foreach(Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine(automobile.GetMake());
    }

    // if (userCar.MaxPrice() && userCar.MaxMiles())
    // {
    //   Console.WriteLine(CarsMatchingSearch);
    // }
    // else
    // {
    //   Console.WriteLine("No Cars match your search.");
    // }
    //
    // foreach(Car automobile in Cars)
    // {
    //   Console.WriteLine(automobile.GetMake());
    // }
    // Console.WriteLine("Enter maximum price: ");
    // string stringMaxPrice = Console.ReadLine();
    // int maxPrice = int.Parse(stringMaxPrice);

  }
}
