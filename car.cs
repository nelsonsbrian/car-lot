using System;
using System.Collections.Generic;

class Car
{
  private string _makeModel;
  private int _price;
  private int _miles;
  private bool _isUsed;
  private string _aboutCar;

  public Car(string makeModel, int price, int miles, bool isUsed = true)
  {
    _makeModel = makeModel;
    _price = price;
    _miles = miles;
    _isUsed = isUsed;
  }

  public bool WorthBuying(int maxPrice)
  {
    return _price < (maxPrice + 100);
  }

  public void SetPrice(int price)
  {
    _price = price;
  }

  public int GetPrice()
  {
    return _price;
  }

  public string GetMakeModel()
  {
    return _makeModel;
  }

  public int GetMiles()
  {
    return _miles;
  }

  public void SetAboutCar(string about)
  {
    _aboutCar = about;
  }

  public string GetAboutCar()
  {
    return _aboutCar;
  }

}

public class Program
{

  public static void ResetProgram()
  {
    Console.WriteLine("Welcome to Joe's Car Lot");
    Console.WriteLine("------------------------");
    Console.WriteLine("Pick from the following options:");
    Console.WriteLine("1) See all of the cars available");
    Console.WriteLine("2) See what cars are worth buying");
    Console.WriteLine("3) Exit program");
  }

  public static void Main()
  {
    Car porsche = new Car("2014 Porsche 911", 114991, 7864, false);
    Car ford = new Car("2011 Ford F450", 55995, 14241);
    Car lexus = new Car("2013 Lexus RX 350", 44700, 20000);
    Car mercedes = new Car("Mercedes Bens ClS550", 39900, 37979);
    Car saturn = new Car("2005 Saturn Ion", 2999, 159345);

    saturn.SetAboutCar("Well Maintained and good condition.");
    porsche.SetAboutCar("Brand new, never used");
    lexus.SetAboutCar("Only 1 previous owner");
    mercedes.SetAboutCar("End of the year model sale!!!");

    List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes, saturn };

    ResetProgram();
    string menu;
    Console.WriteLine("Enter your number:");
    menu = Console.ReadLine();
    if (menu == "1")
    {
      Console.WriteLine("Here are all of the cars:");
      foreach(Car car in Cars)
      {
        Console.WriteLine(car.GetMakeModel() + " with " + car.GetMiles() + "miles for only $" + car.GetPrice());

      }
      Main();
    } else if (menu == "2")
    {
      Console.WriteLine("To see what cars are worth buying,");
      Console.WriteLine("Enter maximum price: ");
      string stringMaxPrice = Console.ReadLine();
      int maxPrice = int.Parse(stringMaxPrice);

      Console.WriteLine("Enter maximum miles: ");
      string stringMaxMiles = Console.ReadLine();
      int maxMiles = int.Parse(stringMaxMiles);

      List<Car> CarsMatchingSearch = new List<Car>(0);


      foreach (Car automobile in Cars)
      {
        if (automobile.WorthBuying(maxPrice))
        {
          CarsMatchingSearch.Add(automobile);
        }
      }

      foreach(Car automobile in CarsMatchingSearch)
      {
        Console.WriteLine(automobile.GetMakeModel() + " with " + automobile.GetMiles() + "miles ---" + automobile.GetAboutCar());
      }
      Main();
    } else if (menu == "3")
    {
      Console.WriteLine("Thank for visiting Joe's Car Lot! Come back anytime.");
      Environment.Exit(0);
    }
  }
}
