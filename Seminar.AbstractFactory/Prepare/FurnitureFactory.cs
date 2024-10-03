namespace Seminar.AbstractFactory.Prepare;

internal interface IFurnitureFactory
{
	IChair CreateChair();
	ICoffeTable CreateCoffeeTable();
	ISofa CreateSofa();
}

internal class VictorianFurnitureFactory : IFurnitureFactory
{
	public IChair CreateChair() => new VictorianChair();

	public ICoffeTable CreateCoffeeTable() => new VictorianCoffeeTable();

	public ISofa CreateSofa() => new VictorianSofa();
}

internal class ArtDecoFurnitureFactory : IFurnitureFactory
{
	public IChair CreateChair() => new ArtDecoChair();

	public ICoffeTable CreateCoffeeTable() => new ArtDecoCoffeeTable();

	public ISofa CreateSofa() => new ArtDecoSofa();
}

internal class ModernFurnitureFactory : IFurnitureFactory
{
	public IChair CreateChair() => new ModernChair();

	public ICoffeTable CreateCoffeeTable() => new ModernCoffeeTable();

	public ISofa CreateSofa() => new ModernSofa();
}
