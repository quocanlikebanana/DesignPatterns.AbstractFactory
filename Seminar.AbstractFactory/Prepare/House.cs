namespace Seminar.AbstractFactory.Prepare;

internal interface IHouse
{
	void AddFurniture(IFurniture modernFurniture);
	void DisplayFurnitures();
}

internal class ModernHouse : IHouse
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

// Different furniture-adder for adding strategy
internal abstract class FurnitureAdderBase
{
	protected readonly IFurnitureFactory _furnitureFactory;

	public FurnitureAdderBase(IFurnitureFactory furnitureFactory)
	{
		_furnitureFactory = furnitureFactory;
	}

	public abstract void AddFurnitures(IHouse house);
}

// Basic adding stategy: 2 chairs, 1 coffee table, 1 sofa
internal class BasicFurnitureAdder : FurnitureAdderBase
{
	public BasicFurnitureAdder(IFurnitureFactory furnitureFactory) : base(furnitureFactory)
	{
	}

	public override void AddFurnitures(IHouse house)
	{
		house.AddFurniture(_furnitureFactory.CreateChair());
		house.AddFurniture(_furnitureFactory.CreateCoffeeTable());
		house.AddFurniture(_furnitureFactory.CreateSofa());
		house.AddFurniture(_furnitureFactory.CreateChair());
	}
}
