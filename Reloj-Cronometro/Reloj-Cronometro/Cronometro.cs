using System;

namespace RelojCronometro
{
	public class Cronometro
	{
		public Cronometro ()
		{
			for (int h = 0; h <= 24; h++) {
				for(int m = 0; m <= 60; m++) {
					for(int s = 0; s <= 60; s++) {

						Console.WriteLine(h +  ":" + m + ":" + s);
						System.Threading.Thread.Sleep(1000);
						Console.Clear();
			}
		 }
	}
		}
	}
}

