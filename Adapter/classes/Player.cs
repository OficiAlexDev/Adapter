using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Player
    {
		public string name;
		private decimal xp;
		private double life;
		public Player(string name, decimal xp, double life)
		{
			this.name = name;
			this.xp = xp;
			this.life = life;
		}
	}
}

