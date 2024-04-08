namespace Properties_LastName_FirstName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //assigns ford and mustang to the make and model classes for "car"
            Car car = new Car();
            car.Make = "Ford";
            car.Model = "Mustang";

            //prints the make and model for "car" to console
            Console.WriteLine($"Make: {car.Make}, Model: {car.Model}");

            //assigns chevy and camero to the make and model classes for "car2"
            Car car2 = new Car();
            car2.Make = "Chevy";
            car2.Model = "Camero";

            //prints the make and model for "car2" to console
            Console.WriteLine($"Make: {car2.Make}, Model: {car2.Model}");

            Car car3 = new Car();
            Console.WriteLine($"Make: {car3.Make}, Model: {car3.Model}");
        }
    }
}