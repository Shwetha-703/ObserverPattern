using System;
namespace Observer_Pattern.Models
{
	public interface Observer
	{
		void Update(float temp, float humidty, float pressure);
	}
}

