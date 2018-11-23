using System;
using System.Collections.Generic;

namespace HouseParty
{
	class Program
	{
		static void Main(string[] args)
		{
			int countOfCommands = int.Parse(Console.ReadLine());
			List<string> guests = new List<string>();

			for (int i = 0; i < countOfCommands; i++)
			{
				string commands = Console.ReadLine();

				string[] commandsArray = commands.Split(" ");
				string name = commandsArray[0];

				if (commandsArray.Length == 3)
				{
					for (int j = 0; j <= guests.Count; j++)
					{
						if (guests.Count == 0)
						{
							guests.Add(name);
						}
						else if (guests[j - 1].Equals(name))
						{
							Console.WriteLine($"{name} is already in the list!");
						}
						else
						{
							guests.Add(name);
						}
					}
				}

				if (commandsArray.Length == 4)
				{
					for (int k = 0; k <= guests.Count ; k++)
					{
						if (!guests[k].Equals(name))
						{
							Console.WriteLine($"{name} is not in the list!");
						}
						else
						{
							guests.Remove(name);
						}
					}
				}
			}

			Console.WriteLine(String.Join(" ", guests));
		}
	}
}
