public class DayWeather : Weather
{
    public double RainAmount { get; set; }

    // Konstruktor som anropar basklassens konstruktor och s�tter RainAmount
    public DayWeather(double temperature, double windSpeed, double humidity, double rainAmount)
        : base(temperature, windSpeed, humidity)
    {
        RainAmount = rainAmount;
    }

    // Metod f�r att visa dagsv�dret, inklusive nederb�rd
    public void DisplayDayWeather()
    {
        DisplayWeather(); // Anropar basklassens metod f�r att visa grundl�ggande v�derinfo
        Console.WriteLine($"Nederb�rd: {RainAmount} mm");
    }
}

