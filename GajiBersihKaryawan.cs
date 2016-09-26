using System;
using System.Collections.Generic;
using System.Text;

namespace GajiBersihKaryawan
{
	class GajiBersihKaryawan
	{
		public static void Main(string[] args)
		{
			const double PersenTunjangan=0.2, PersenPajak=0.15;
			string nama;
			double GajiPokok=0,Tunjangan=0,Pajak=0,GajiBersih=0;
			System.Console.Out.WriteLine("Masukkan Nama dan Gaji Pokok Anda Secara Berurutan: ");
			nama=System.Convert.ToString(System.Console.In.ReadLine());
			GajiPokok=System.Convert.ToDouble(System.Console.In.ReadLine());
			Tunjangan=PersenTunjangan*GajiPokok;
			System.Console.Out.WriteLine("Tunjangan= {0}",Tunjangan);
			Pajak=PersenPajak*(GajiPokok+Tunjangan);
			System.Console.Out.WriteLine("Pajak= {0}",Pajak);
			GajiBersih=GajiPokok+Tunjangan-Pajak;
			System.Console.Out.WriteLine("Saudara {0}, Gaji Bersih anda adalah {1}",nama,GajiBersih);
		}
	}
}