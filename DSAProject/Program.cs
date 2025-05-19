using DSAProject;
using System.Diagnostics;

class Program
{
   static void Main(string[] args)
    {
        Console.WriteLine("\n--- Default Constructor ---");
        Car car1 = new Car();
        car1.Display();

        Console.WriteLine("\n--- Parameterized Constructor ---");
        Car car2 = new Car("BMW", "X5");
        car2.Display();

        Console.WriteLine("\n--- Copy Constructor ---");
        Car car3 = new Car(car2);
        car3.Display();

        Console.WriteLine("\n--- Private Constructor via Static Method ---");
        Car special = Car.CreateSpecialCar();
    }
}