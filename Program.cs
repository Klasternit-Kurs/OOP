using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	class Racun
	{
		//Stanja ili polja
		public string Ime;
		public static string StaticnoIme;
		public string Prezime;
		public decimal bilans = 1000; //Podrazumevana vrednost

		//ref je kljucna rec koja i primitivan tip
		//salje po referenci
		public int Saberi(ref int x, int y)
		{
			x += 10;
			y += 11;
			if (x > 0)
			{
				return x + y;
			}
			return 0;
		}

		public void PrikaziBilans()
		{
			Console.WriteLine($"Bilans je {bilans} RSD");
		}

		public static void FooBar()
		{
			Console.WriteLine("Staticna metoda");
		}



		//Konstuktor
		public Racun(string ime, string p, decimal b)
		{
			Ime = ime;
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

	class Program
	{
		static void Main()
		{
			Racun.FooBar();
			Racun.StaticnoIme = "Pera";
			Racun r55 = new Racun();
			r55.Ime = "Pera";
			Racun r = new Racun("Pera", "Peric", 5000);
			//r.bilans = 5000;
			//r.Ime = "Pera";
			//r.Prezime = "Peric";
			r.PrikaziBilans();


			Racun r1 = new Racun("Neko", "Nekic");
			//r1.bilans = 2134;
			//r1.Ime = "Neko";
			//r1.Prezime = "Nekic";
			r1.PrikaziBilans();
			Console.WriteLine($"Ime {r.Ime}, prezime {r.Prezime}, bilans {r.bilans}");
			//Console.WriteLine($"Ime {r1.Ime}, prezime {r1.Prezime}, bilans {r1.bilans}");


			int x = 6;
			int y = 8;
			int zbir = r1.Saberi(ref x, y);
			Console.WriteLine($"{x} + {y} = {zbir}");
			
			Console.ReadKey();
		}
	}

	
}
