using ConsoleApp.Classes;

class Program
{
	static void Main(string[] args)
	{
		Student student1 = new("Dariusz", "Begiedza", 27);
		student1.Greet("Marcin");

		student1.Name = "elo";
		student1.Greet("Marek");
	}
}
