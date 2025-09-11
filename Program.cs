using ConsoleApp.Factories;
using ConsoleApp.Interfaces;

class Program
{
	static void Main(string[] args)
	{
		Logger logger = Logger.GetInstance();

		ICarFactory factory = new CarFactory();
		// CarFactory factory = new();

		logger.Log("Hello!");

		ICar car1 = factory.CreateCar("sedan");
		car1.Drive();

		ICar car2 = factory.CreateCar("suv");
		car2.Drive();
	}
}
