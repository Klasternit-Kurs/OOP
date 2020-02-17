using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	class Program
	{
		static void Main(string[] args)
		{
			int x = 5;


			Racun r = new Racun("Pera", "Peric", 5000);
			//r.bilans = 5000;
			//r.Ime = "Pera";
			//r.Prezime = "Peric";

			Racun r1 = new Racun("Neko", "Nekic");
			//r1.bilans = 2134;
			//r1.Ime = "Neko";
			//r1.Prezime = "Nekic";

			Console.WriteLine($"Ime {r.Ime}, prezime {r.Prezime}, bilans {r.bilans}");
			//Console.WriteLine($"Ime {r1.Ime}, prezime {r1.Prezime}, bilans {r1.bilans}");

			Console.ReadKey();
		}
	}

	class Racun
	{
		//Stanja
		public string Ime;
		public string Prezime;
		public decimal bilans = 1000; //Podrazumevana vrednost


		//Konstuktor
		public Racun(string i, string p, decimal b)
		{
			Ime = i;
			Prezime = p;
			if (b == 0)
				bilans = 10000;
			else
				bilans = b;
		}

		public Racun()
		{ }

		public Racun(string i, string p)
		{
			Ime = i;
			Prezime = p;
			
		}

		
	}
}
