using System;
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
        }
    }
}

