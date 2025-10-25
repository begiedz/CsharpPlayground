using ConsoleApp.Decorators;
using ConsoleApp.Factories;
using ConsoleApp.Interfaces;
using ConsoleApp.Models;

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

// Dictionary (HashMap, frequency map)
var dict = new Dictionary<string, int>();
dict["apple"] = 3;
dict["banana"] = 5;

foreach (var keyValue in dict)
    Console.WriteLine($"{keyValue.Key} -> {keyValue.Value}");

// ===
string[] items = { "apple", "banana", "apple", "pear", "banana", "banana" };

var counts = new Dictionary<string, int>();
foreach (var item in items)
    counts[item] = counts.TryGetValue(item, out var count) ? count + 1 : 1;

Console.WriteLine("Counts:");
foreach (var pair in counts)
    Console.WriteLine($"{pair.Key}: {pair.Value}");

// HashSet
var set = new HashSet<int>();
set.Add(10);
set.Add(20);

foreach (var entry in set)
    Console.WriteLine(entry);
