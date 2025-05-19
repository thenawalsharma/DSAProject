using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAProject
{
    public class Car
    {
        public string Brand;
        public string Model;
        public static string Company;


        // Default Constructor
        public Car()
        {
            Brand = "DefaultBrand";
            Model = "DefaultModel";
            Console.WriteLine("Default Constructor called");
        }

        // Parameterized Constructor
        public Car(string brand, string model)
        {
            Brand = brand;
            Model = model;
            Console.WriteLine("Parameterized Constructor called");
        }

        // Copy Constructor
        public Car(Car existingCar)
        {
            Brand = existingCar.Brand;
            Model = existingCar.Model;
            Console.WriteLine("Copy Constructor called");
        }

        // Private Constructor
        private Car(string message)
        {
            Console.WriteLine("Private Constructor: " + message);
        }

        // Static method to access private constructor
        public static Car CreateSpecialCar()
        {
            return new Car("Special Car created internally");
        }


        // Static Constructor
        static Car()
        {
            Company = "Mercedes-Benz";
            Console.WriteLine("Static Constructor called");
        }

        public void Display()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Company: {Company}");
        }
    }
}
