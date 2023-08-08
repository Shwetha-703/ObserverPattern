using System;
using Observer_Pattern.Models;

namespace Observer_Pattern.Services
{

	public interface IApplication
	{
		void Run();
	}

	public class Application : IApplication
	{

        public void Run()
        {
			Console.WriteLine("Observer pattern!");

			WeatherData weatherData = new();
			CurrentConditionsDisplay currentDisplay = new(weatherData);
            ForeCastDisplay forecastDisplay = new(weatherData);
            weatherData.SetMeasurements(30, 65, 30.3f);
            weatherData.SetMeasurements(22, 70, 28.3f);
            weatherData.SetMeasurements(25, 80, 29.9f);
        }
    }
}

