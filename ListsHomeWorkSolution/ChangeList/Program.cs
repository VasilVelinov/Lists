using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ChangeList
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> integers = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToList();

			string input = String.Empty;

			while ((input = Console.ReadLine()) != "end")
			{
				string[] commandArray = input.Split(" ").ToArray();

				string command = commandArray[0];
				if (command.Equals("Delete"))
				{
					int deleteIndex = int.Parse(commandArray[1]);
					integers.RemoveAll(x => x == deleteIndex);
				}
				else if (command.Equals("Insert"))
				{
					int element = int.Parse(commandArray[1]);
					int position = int.Parse(commandArray[2]);

					integers.Insert(position, element);
				}
			}

			Console.WriteLine(String.Join(" ", integers));
		}
	}
}
