using System;
using System.Collections.Generic;
using System.Text;

namespace InputOutput
	{
	class Input
		{
		public static void Main(string[] args)
			{
				int a=0,b=0,c=0;
				Console.Out.WriteLine("Masukkan Bilangan Bulat yang Anda Inginkan pada A dan B.");
				a=Convert.ToInt32(Console.In.ReadLine());
				b=Convert.ToInt32(Console.In.ReadLine());
				c=a+b;
				Console.Out.WriteLine("Nilai C=A+B adalah {0}",c);
				Console.ReadLine();
			}
		}
	}