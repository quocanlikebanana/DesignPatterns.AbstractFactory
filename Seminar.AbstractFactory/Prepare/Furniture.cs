namespace Seminar.AbstractFactory.Prepare;

internal interface IFurniture
{
	string GetFurnitureName();
}

internal interface IChair : IFurniture
{
	void Sits();
}

internal class VictorianChair : IChair
{
	public string GetFurnitureName() => "[Victorian] [Chair]";
	public void Sits() => Console.WriteLine("Sitting on a [Victorian] [Chair].");
}

internal class ArtDecoChair : IChair
{
	public string GetFurnitureName() => "[Art Deco] [Chair]";
	public void Sits() => Console.WriteLine("Sitting on a [Art Deco] [Chair].");
}

internal class ModernChair : IChair
{
	public string GetFurnitureName() => "[Modern] [Chair]";
	public void Sits() => Console.WriteLine("Sitting on a [Modern] [Chair].");
}


internal interface ICoffeTable : IFurniture
{
	void PlaceStuffs(string stuff);
}

internal class VictorianCoffeeTable : ICoffeTable
{
	public string GetFurnitureName() => "[Victorian] [Table]";
	public void PlaceStuffs(string stuff) => Console.WriteLine($"Placing [{stuff}] on [Victorian] [Table].");
}

internal class ArtDecoCoffeeTable : ICoffeTable
{
	public string GetFurnitureName() => "[Art Deco] [Table]";
	public void PlaceStuffs(string stuff) => Console.WriteLine($"Placing [{stuff}] on [Art Deco] [Table].");
}

internal class ModernCoffeeTable : ICoffeTable
{
	public string GetFurnitureName() => "[Modern] [Table]";
	public void PlaceStuffs(string stuff) => Console.WriteLine($"Placing [{stuff}] on [Modern] [Table].");
}

internal interface ISofa : IFurniture
{
	void SleepOn();
}

internal class VictorianSofa : ISofa
{
	public string GetFurnitureName() => "[Victorian] [Sofa]";
	public void SleepOn() => Console.WriteLine("Sleeping on on a [Victorian] [Sofa]. zzzZz");
}

internal class ArtDecoSofa : ISofa
{
	public string GetFurnitureName() => "[Art Deco] [Sofa]";
	public void SleepOn() => Console.WriteLine("Sleeping on on a [Art Deco] [Sofa]. zZzz");
}

internal class ModernSofa : ISofa
{
	public string GetFurnitureName() => "[Modern] [Sofa]";
	public void SleepOn() => Console.WriteLine("Sleeping on on a [Modern] [Sofa]. ZzzZZzz");
}
