﻿namespace Properties_LastName_FirstName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "Ford";
            car.Model = "Mustang";

            Console.WriteLine($"Make: {car.Make}, Model: {car.Model}");

            Car car2 = new Car();
            car2.Make = "Chevy";
            car2.Model = "Camero";

            Console.WriteLine($"Make: {car2.Make}, Model: {car2.Model}");

            Car car3 = new Car();
            Console.WriteLine($"Make: {car3.Make}, Model: {car3.Model}");
        }
    }
}