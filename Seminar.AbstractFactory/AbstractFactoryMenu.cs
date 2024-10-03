using Client;
using Seminar.AbstractFactory.Examples;

namespace Seminar.AbstractFactory
{
	public class AbstractFactoryMenu
	{
		private readonly IExample _badExample;
		private readonly IExample _goodExample;
		private readonly IExample _betterExample;

		public AbstractFactoryMenu()
		{
			_badExample = new BadExample();
			_goodExample = new GoodExample();
			_betterExample = new BetterExample();
		}

		public Menu CreateMenu() => new Menu(new Dictionary<string, IExample> {
			{ "1", _badExample },
			{ "2", _goodExample },
			{ "3", _betterExample },
		});
	}
}
