namespace WeatherApp
{
    public class WeatherData
    {
        public double Temperature { get; set; }
        public double WindSpeed { get; set; }
        public double RainAmount { get; set; }

        public WeatherData(double temperature, double windSpeed, double rainAmount)
        {
            Temperature = temperature;
            WindSpeed = windSpeed;
            RainAmount = rainAmount;
        }

        public void DisplayWeather()
        {
            Console.WriteLine($"Temperature: {Temperature} °C");
            Console.WriteLine($"Wind Speed: {WindSpeed} m/s");
            Console.WriteLine($"Rain Amount: {RainAmount} mm");
        }
    }
}
