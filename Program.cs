using System;
using System.Collections.Generic;

namespace WeatherApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exempel på städer med väderdata
            var cities = new Dictionary<string, WeatherData>
            {
                { "New York", new WeatherData(15.0, 5.5, 60.0) },
                { "Tokyo", new WeatherData(22.0, 3.8, 70.0) },
                { "Paris", new WeatherData(18.5, 2.2, 55.0) },
                { "Stockholm", new WeatherData(10.0, 7.1, 80.0) },
                { "Sydney", new WeatherData(25.3, 6.0, 65.0) }
            };

            // Välkomstmeddelande
            Console.WriteLine("Välkommen till WeatherApp!");

            // Visa lista över städer
            Console.WriteLine("\nVälj en stad genom att skriva dess namn:");
            foreach (var city in cities.Keys)
            {
                Console.WriteLine($"- {city}");
            }

            // Hämta användarens val
            Console.Write("\nAnge stad: ");
            string chosenCity = Console.ReadLine();

            // Kontrollera om staden finns i listan och visa väderdata
            if (cities.TryGetValue(chosenCity, out WeatherData selectedCityWeather))
            {
                Console.WriteLine($"\nVädret i {chosenCity}:");
                selectedCityWeather.DisplayWeather();
            }
            else
            {
                Console.WriteLine("\nTyvärr, staden finns inte i vår lista. Försök igen.");
            }
        }
    }
}
