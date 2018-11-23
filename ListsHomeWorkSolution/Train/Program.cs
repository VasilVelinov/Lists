using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
			int maxWagonCapacity = int.Parse(Console.ReadLine());

			string input = String.Empty;

			while ((input = Console.ReadLine()) != "end")
			{
				string[] command = input.Split().ToArray();
				if (command.Length > 1)
				{
					wagons.Add(int.Parse(command[1]));
				}
				else
				{
					for (int i = 0; i < wagons.Count; i++)
					{
						int passengersToAdd = int.Parse(command[0]);
						if (wagons[i] + passengersToAdd <= maxWagonCapacity)
						{
							wagons[i] += passengersToAdd;
							break;
						}
					}
				}
			}

			Console.WriteLine(String.Join(" ", wagons));
		}
	}
}
