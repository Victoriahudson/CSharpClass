using System;

/*This class goes over Lesson 14 content
Static */
namespace CSharpClass.Lessons
{   
    public static class Lesson14Static
    {
        static readonly int baseTemp;

        static Lesson14Static()
        {
            baseTemp = 32;
        }

        // static method 1
        public static void CelsiusToFahrenheit(string tempature)
        {
            double celsius = Double.Parse (tempature);
            double fahrenheit = (celsius * 9 / 5) + baseTemp;
            Console.WriteLine(fahrenheit);
        }   

        public static void FahrenheitToCelsius(string tempature)
        {
            double fahrenheit = Double.Parse(tempature);
            double celsius = (fahrenheit - baseTemp) * 5 / 9;
            Console.WriteLine(celsius);
        }

    }
}