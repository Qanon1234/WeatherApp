public class Weather
{
    public double Temperature { get; set; }
    public double WindSpeed { get; set; }
    public double Humidity { get; set; }

    // Konstruktor som tar in tre parametrar och sätter egenskaperna
    public Weather(double temperature, double windSpeed, double humidity)
    {
        Temperature = temperature;
        WindSpeed = windSpeed;
        Humidity = humidity;
    }

    // Metod för att visa vädret
    public void DisplayWeather()
    {
        Console.WriteLine($"Temperatur: {Temperature}°C");
        Console.WriteLine($"Vindhastighet: {WindSpeed} m/s");
        Console.WriteLine($"Luftfuktighet: {Humidity}%");
    }
}
