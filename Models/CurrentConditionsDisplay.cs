using System;
namespace Observer_Pattern.Models
{
	public class CurrentConditionsDisplay : Observer, DisplayElement
	{
        private float temp;
        private float humidity;
        private float pressure;
        private Subject weatherData;

        public CurrentConditionsDisplay(Subject weatherData)
		{
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
		}

        public void Display()
        {
            Console.WriteLine("Current Conditions: " + temp + "C degrees and " + humidity + "% humidity");
        }

        public void Update(float temp, float humidty, float pressure)
        {
            this.temp = temp;
            this.humidity = humidty;
            this.pressure = pressure;
            Display();
        }
    }
}

