using System;

namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            var celsius = TempConverter.FahrenheitToCelsius(32);
            Console.WriteLine(celsius);

            var fahrenheit = TempConverter.CelsiusToFahrenheit(0);
            Console.WriteLine(fahrenheit);

            //Create a new console app called StaticExercise.Now create a static class 
            //called TempConverter.The class should have at least 2 methods, one called FahrenheitToCelsius
            //that will require a double as a parameter and return a double, the other CelsiusToFahrenheit 
            //which will also require a double as a parameter and return a double. Fill out these methods and
            //call them in your Program.cs file.Make sure they’re accurate!
        }
    }
}
