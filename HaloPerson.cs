using System;
using System.Collections.Generic;
using System.Text;

namespace HaloPerson
{
	class HaloPerson
	{
		public static void Main(string[] args)
		{
			System.Console.Out.WriteLine("Masukkan Nama Anda: ");
			string nama;
			nama=System.Convert.ToString(System.Console.In.ReadLine());
			System.Console.Out.WriteLine("Halo {0} ", nama);
		}
	}
}