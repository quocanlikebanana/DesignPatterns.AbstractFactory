using Client;
using Seminar.AbstractFactory;
using Seminar.AbstractFactory.Examples;

namespace Output.ConsoleApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Menu menu = new AbstractFactoryMenu().CreateMenu();
			menu.ShowMenu();
		}
	}
}
