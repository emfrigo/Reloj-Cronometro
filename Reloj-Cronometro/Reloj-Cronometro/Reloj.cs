using System;

namespace RelojCronometro
{
	public class Reloj
	{
		public Reloj ()
		{
			for (int h = DateTime.Now.Hour; h <= 24; h++) {
				for(int m = DateTime.Now.Hour; m <= 60; m++) {
					for(int s = DateTime.Now.Hour; s <= 60; s++) {

						Console.WriteLine(h +  ":" + m + ":" + s);
						System.Threading.Thread.Sleep(1000);
						Console.Clear();
			}
		 }
	}
}

	}
}