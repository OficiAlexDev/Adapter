using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
	public class BattleRoyal
	{
		List<Player> players = new List<Player>();
		public void FindPlayers(Player player)
		{
			players.Add(player);
		}
		public string ShowPlayers()
		{
			string playersInfo = "";
			for (int i = 0; i < players.Count; i++)
			{
				playersInfo += $"{this.players[i].name} \n";
			}
			return playersInfo;
		}
	}
}

