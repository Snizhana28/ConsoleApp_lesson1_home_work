using System;

namespace ConsoleApp_lesson1_home_work
{
    internal class Program
    {
        static double FahrenheitToCelsius(double fahrenheit)
        {
             return (fahrenheit - 32) * 5 / 9;
        }
        static double CelsiusToFahrenheit(double celsius)
        { 
            return (celsius * 9 / 5) + 32; 
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a temperature readings : ");
            double temperature = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose : \n1. Convert from Fahrenheit to Celsius \n2. Convert from Celsius to Fahrenheit");
            int num = Convert.ToInt32(Console.ReadLine());
            double convertedTemperature;
            switch (num)
            {
                case 1:
                    convertedTemperature = FahrenheitToCelsius(temperature);
                    Console.WriteLine($"Temperature in Celsius: {convertedTemperature} °C");
                    break;
                case 2:
                    convertedTemperature = CelsiusToFahrenheit(temperature);
                    Console.WriteLine($"Temperature in Fahrenheit: {convertedTemperature} °F");
                    break;
                default:
                    Console.WriteLine("Invalid option selection.");
                    break;
            }
        }
    }
}