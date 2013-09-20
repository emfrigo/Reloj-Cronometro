using System;

namespace RelojCronometro
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int sel;

			Console.WriteLine("Hola mundo \n Seleccione una opcion \n1)Reloj  \n2)Cronometro");
			sel = Convert.ToInt32(Console.ReadLine());
			switch(sel){
			case 1:
				new Reloj();
				break;
			case 2:
				new Cronometro();
				break;
			}
				
		}
	}
}
