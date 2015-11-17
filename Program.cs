using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MontyHallGame
{
	class Program
	{
		static void Main(string[] args)
		{
			var mh = new MontyHall();
			Console.WriteLine(mh.ToString());
			Console.ReadKey();
		}
	}
}
