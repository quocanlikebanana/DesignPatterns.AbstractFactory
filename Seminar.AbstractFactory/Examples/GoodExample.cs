using Client;
using Seminar.AbstractFactory.Prepare;

namespace Seminar.AbstractFactory.Examples
{
	public class GoodExample : IExample
	{
		public string GetName() => "Using abstract factory to add modern furniture";

		public void Run()
		{
			Console.WriteLine("($$) Using abstract factory to add modern furniture:");
			Console.WriteLine("\n-----------------------------------------\n");
			ModernHouse house = new ModernHouse();
			IFurnitureFactory furnitureFactory = new ModernFurnitureFactory();
			Console.WriteLine("(*) Put a set of furnitures into our [Modern] house");
			house.AddFurniture(furnitureFactory.CreateChair());
			house.AddFurniture(furnitureFactory.CreateCoffeeTable());
			house.AddFurniture(furnitureFactory.CreateSofa());
			house.AddFurniture(furnitureFactory.CreateChair());
			Console.WriteLine("\n-----------------------------------------\n");
			house.DisplayFurnitures();
			Console.WriteLine("\n-----------------------------------------\n");
			Console.WriteLine("=> All furnitures are [Modern], and we don't have to concern about adding the wrong type.");
			Console.WriteLine("=> Still able to add [non-Modern] furniture into our house.");
		}
	}
}
