using Client;
using Seminar.AbstractFactory.Prepare;

namespace Seminar.AbstractFactory.Examples
{
	public class BadExample : IExample
	{
		public string GetName() => "Add furnitures without abstract factory";

		public void Run()
		{
			Console.WriteLine("($$) Add furnitures without abstract factory:");
			Console.WriteLine("\n-----------------------------------------\n");
			ModernHouse house = new ModernHouse();
			Console.WriteLine("(*) Put a set of furnitures into our [Modern] house");
			house.AddFurniture(new ModernChair());
			house.AddFurniture(new ModernCoffeeTable());
			house.AddFurniture(new ModernSofa());
			house.AddFurniture(new ArtDecoChair()); // Oopsie...
			Console.WriteLine("\n-----------------------------------------\n");
			house.DisplayFurnitures();
			Console.WriteLine("\n-----------------------------------------\n");
			Console.WriteLine("=> We accidentally added [ArtDeco] [Chair]");
		}
	}
}
