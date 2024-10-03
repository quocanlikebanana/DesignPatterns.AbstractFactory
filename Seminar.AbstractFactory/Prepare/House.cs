namespace Seminar.AbstractFactory.Prepare;

internal class ModernHouse
{
	private readonly List<IFurniture> _furnitures;

	public ModernHouse()
	{
		_furnitures = new List<IFurniture>();
	}

	public void AddFurniture(IFurniture modernFurniture)
	{
		_furnitures.Add(modernFurniture);
	}

	public void DisplayFurnitures()
	{
		foreach (IFurniture furniture in _furnitures)
		{
			Console.WriteLine(furniture.GetFurnitureName());
		}
	}
}

internal class ModernHouseFactory
{
	private readonly IFurnitureFactory _furnitureFactory;
	private ModernHouse _modernHouse;

	public ModernHouseFactory(ModernFurnitureFactory modernFurnitureFactory)
	{
		_furnitureFactory = modernFurnitureFactory;
		_modernHouse = new ModernHouse();
	}

	public void AddChair()
	{
		_modernHouse.AddFurniture(_furnitureFactory.CreateChair());
	}

	public void AddCoffeeTable()
	{
		_modernHouse.AddFurniture(_furnitureFactory.CreateCoffeeTable());
	}

	public void AddSofa()
	{
		_modernHouse.AddFurniture(_furnitureFactory.CreateSofa());
	}

	public ModernHouse BuildModernHouse()
	{
		ModernHouse modernHouse = _modernHouse;
		_modernHouse = new ModernHouse();
		return modernHouse;
	}
}

