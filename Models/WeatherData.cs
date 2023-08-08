using System;
namespace Observer_Pattern.Models
{
	public class WeatherData : Subject
	{
        private float temp;
        private float humidity;
        private float pressure;
        List<Observer> observers = new();

        public WeatherData()
		{
		}

        public void SetMeasurements(float temp, float humidity, float pressure)
        {
            this.temp = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }

        private void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void NotifyObservers()
        {
            foreach(Observer o in observers)
            {
                o.Update(temp, humidity, pressure);
            }
        }

        public void RegisterObserver(Observer o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(Observer o)
        {
            int i = observers.IndexOf(o);
            if (i >= 0)
            {
                observers.Remove(o);
            }
        }

    }
}

