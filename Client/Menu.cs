namespace Client;

public class Menu
{
	private readonly Dictionary<string, IExample> _exampleStringDictionary;

	public Menu(Dictionary<string, IExample> exampleStringDictionary)
	{
		if (exampleStringDictionary.ContainsKey("0"))
		{
			throw new ArgumentException($"Cannot contain \"0\" key");
		}
		_exampleStringDictionary = exampleStringDictionary;
	}

	public void ShowMenu()
	{
		do
		{
			foreach (KeyValuePair<string, IExample> keyValuePair in _exampleStringDictionary)
			{
				Console.WriteLine($"{keyValuePair.Key}: {keyValuePair.Value.GetName()}");
			}
			Console.Write("Input: ");
			string? input = Console.ReadLine();
			Console.WriteLine("=================================================================================");
			if (input == "0")
			{
				break;
			}
			if (input != null && _exampleStringDictionary.TryGetValue(input, out IExample? example) == true)
			{
				_exampleStringDictionary[input].Run();
			}
			else
			{
				Console.WriteLine("Invalid input: " + input);
			}
			Console.ReadLine();
			Console.Clear();
		} while (true);
		Console.WriteLine("Program exited");
	}
}
