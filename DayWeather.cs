public class DayWeather : Weather
{
    public double RainAmount { get; set; }

    // Konstruktor som anropar basklassens konstruktor och sätter RainAmount
    public DayWeather(double temperature, double windSpeed, double humidity, double rainAmount)
        : base(temperature, windSpeed, humidity)
    {
        RainAmount = rainAmount;
    }

    // Metod för att visa dagsvädret, inklusive nederbörd
    public void DisplayDayWeather()
    {
        DisplayWeather(); // Anropar basklassens metod för att visa grundläggande väderinfo
        Console.WriteLine($"Nederbörd: {RainAmount} mm");
    }
}

