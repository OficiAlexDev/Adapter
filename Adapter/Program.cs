using Adapter;
using System;
using System.Collections.Generic;

namespace Adapter
{
	class Program
	{
		static void Main()
		{
			//Game infos
			string[,] playerOnDB = Database.Get(); // Database request
			//Using adapter to make a Player Object for battleroyal match
			BattleRoyal match = new BattleRoyal();
			for (int i = 0; i < playerOnDB.Length / 3; i++)
			{
                match.FindPlayers(Adapter.ToPlayer(new string[] { playerOnDB[i, 0], playerOnDB[i, 1], playerOnDB[i, 2] }));
			}
			Console.WriteLine(match.ShowPlayers());
		}
	}
}

