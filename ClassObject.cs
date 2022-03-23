using System;

namespace LatihanClassdanObject
{
  class Program
  {
    static void Main(string[] args)
    {
      //membuat objek taxi
      Taxi taxi = new Taxi();
      
      //set nilai properties
      taxi.DriverName = "Jono";
      taxi.OnDuty = true;
      taxi.NumPassenger= 10;
      
      //memanggil method
      taxi.TaxiInfo();
      taxi.PickUpPassenger();
      taxi.DropOffPassenger();
      
      Console.ReadKey();
    }
  }
}

