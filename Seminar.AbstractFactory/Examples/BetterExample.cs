using Client;
using Seminar.AbstractFactory.Prepare;

namespace Seminar.AbstractFactory.Examples;

public class BetterExample : IExample
{
	public string GetName() => "We encapsulate the creation inside a wrapper class";

	public void Run()
	{
		Console.WriteLine("($$) We encapsulate the creation inside a wrapper class:");
		Console.WriteLine("\n-----------------------------------------\n");
		ModernHouseFactory modernHouseFactory = new ModernHouseFactory(new ModernFurnitureFactory());
		Console.WriteLine("(*) Put a set of furnitures into our [Modern] house factory");
		modernHouseFactory.AddChair();
		modernHouseFactory.AddCoffeeTable();
		modernHouseFactory.AddSofa();
		modernHouseFactory.AddChair();
		Console.WriteLine("\n-----------------------------------------\n");
		ModernHouse modernHouse = modernHouseFactory.BuildModernHouse();
		modernHouse.DisplayFurnitures();
		Console.WriteLine("\n-----------------------------------------\n");
		Console.WriteLine("=> Now we can ensure all furniture items are [Modern] by using our modern house factory.");
	}
}
