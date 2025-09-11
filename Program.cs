using ConsoleApp.Decorators;
using ConsoleApp.Factories;
using ConsoleApp.Interfaces;
using ConsoleApp.Models;

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

		ICoffee coffee = new SimpleCoffee();
		Console.WriteLine(coffee.GetDescription());
		Console.WriteLine(coffee.GetCost());

		coffee = new MilkDecorator(coffee);
		Console.WriteLine(coffee.GetDescription());
		Console.WriteLine(coffee.GetCost());

		coffee = new SugarDecorator(coffee);
		Console.WriteLine(coffee.GetDescription());
		Console.WriteLine(coffee.GetCost());
	}
}
