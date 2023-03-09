using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
	static public class Adapter
	{
		static public Player ToPlayer(string[] dbData)
		{
			return new Player(dbData[0], Convert.ToDecimal(dbData[1]), Convert.ToDouble(dbData[2]));
		}
	}
}

