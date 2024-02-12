using System;

namespace constructorinheritance
{
    public class Vehicle
    {
        private readonly string registrationNumber;

        // public Vehicle()
        // {
        //     System.Console.WriteLine("Vehicle Is initialized");
            
        // }

         public Vehicle(string registrationNumber)
        {
            this.registrationNumber = registrationNumber;
            System.Console.WriteLine("Vehicle is initialized : {0}", registrationNumber);

        }
    }

    public class Car : Vehicle
    {
        // public Car()
        // {
        //     System.Console.WriteLine("Car is initialized");
        // }

        public Car(string registrationNumber) :base(registrationNumber)
        {
            System.Console.WriteLine("Car is initialized : {0}", registrationNumber);
        }
    }




    class Program
        {
            static void Main(string[] args)
            {
               //var car = new Car();

                var car = new Car("AXSDF232z");
            }
        }
}