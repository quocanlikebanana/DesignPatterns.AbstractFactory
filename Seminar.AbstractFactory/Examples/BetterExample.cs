using Client;
using Seminar.AbstractFactory.Prepare;

namespace Seminar.AbstractFactory.Examples;

public class BetterExample : IExample
{
	public string GetName() => "Encapsulate the creation inside a wrapper class";

	public void Run()
	{
		Console.WriteLine("($$) Encapsulates the creation inside a wrapper class:");
		Console.WriteLine("\n-----------------------------------------\n");
		ModernHouse modernHouse = new ModernHouse();
		ModernFurnitureFactory modernFurnitureFactory = new ModernFurnitureFactory();
		FurnitureAdderBase furnitureAdder = new BasicFurnitureAdder(modernFurnitureFactory, modernHouse);
		Console.WriteLine("(*) Build our modern house with BasicFurnitureAdder");
		furnitureAdder.AddFurnitures();
		Console.WriteLine("\n-----------------------------------------\n");
		modernHouse.DisplayFurnitures();
		Console.WriteLine("\n-----------------------------------------\n");
		Console.WriteLine("=> Now we can ensure all furniture items are [Modern] by using our modern house factory.");
	}
}
