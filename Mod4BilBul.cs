using System;
using System.Collections.Generic;
using System.Text;

namespace mod4
	{
	class mod4
		{
		public static void Main(string[] args)
			{
				int bil=0;
				Console.Out.WriteLine("Masukkan Bilangan Bulat Positif yang Anda Inginkan.");
				bil=Convert.ToInt32(Console.In.ReadLine());
				if (bil%4==0)
					{
						Console.Out.WriteLine("Bilangan habis dibagi Empat.");
					}
				else
						Console.Out.WriteLine("Bilangan tidak habis dibagi Empat.");
				Console.ReadLine();
			}
		}
	}