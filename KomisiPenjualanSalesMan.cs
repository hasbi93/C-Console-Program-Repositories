using System;
using System.Collections.Generic;
using System.Text;

namespace KomisiSalesman
{
	class KomisiSalesman
	{
		public static void Main(string[] args)
		{
			string nama;
			double NilaiPenjualan=0, komisi=0;
			System.Console.Out.WriteLine("Masukkana Nama Anda: ");
			nama=System.Convert.ToString(System.Console.In.ReadLine());
			System.Console.Out.WriteLine("Masukkan Nilai Penjualan Anda: ");
			NilaiPenjualan=System.Convert.ToDouble(System.Console.In.ReadLine());
			komisi=0.05*NilaiPenjualan;
			System.Console.Out.WriteLine("Saudara {0} , komisi penjualan Anda adalah {1} ",nama, komisi);
		}
	}
}