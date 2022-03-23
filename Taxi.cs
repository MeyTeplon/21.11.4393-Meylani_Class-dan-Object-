using System;

namespace LatihanClassdanObject
{
  public class Taxi
  {
    static void Main(string[] args)
    {
      //prolerties
      public string DriveName {get; set;}
      public string OnDuty {get; set;}
      public float NumPassenger {get; set;}
      
      //method
      public void TaxiInfo()
      {
        Console.WriteLine("Driver Name : {0}",DriverName);
        Consile.WriteLine("On Duty : {0}",OnDuty);
        Console.WriteLine("Number of Passenger : {0}",NumPassenger);
      }
      public void PickUpPassenger()
      {
        Console.WriteLine("{0} sedang menjemput penumpang.",DriveName);
      }
      public void DropOffPassenger()
      {
        Console.WriteLine("{0} selesai mengantar penumpang.",DriveName);
      }
    }
  }
}
