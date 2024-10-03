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
	protected readonly IHouse _house;

	public FurnitureAdderBase(IFurnitureFactory furnitureFactory, IHouse house)
	{
		_furnitureFactory = furnitureFactory;
		_house = house;
	}

	public abstract void AddFurnitures();
}

// Basic adding stategy: 2 chairs, 1 coffee table, 1 sofa
internal class BasicFurnitureAdder : FurnitureAdderBase
{
	public BasicFurnitureAdder(IFurnitureFactory furnitureFactory,IHouse house) : base(furnitureFactory, house)
	{
	}

	public override void AddFurnitures()
	{
		_house.AddFurniture(_furnitureFactory.CreateChair());
		_house.AddFurniture(_furnitureFactory.CreateCoffeeTable());
		_house.AddFurniture(_furnitureFactory.CreateSofa());
		_house.AddFurniture(_furnitureFactory.CreateChair());
	}
}
