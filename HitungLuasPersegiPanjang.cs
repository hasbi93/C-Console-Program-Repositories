using System;
using System.Collections.Generic;
using System.Text;

namespace HitungLuasPersegiPanjang
{
	class HitungLuasPersegiPanjang
	{
		public static void Main(string[] args)
		{
			int p=0,l=0,L=0;
			System.Console.Out.WriteLine("Program Hitung Luas Persegi Panjang");
			System.Console.Out.WriteLine("Masukkan Nilai Panjang: ");
			p=System.Convert.ToInt32(System.Console.In.ReadLine());
			System.Console.Out.WriteLine("Masukkan Nilai Lebar: ");
			l=System.Convert.ToInt32(System.Console.In.ReadLine());
			L=p*l;
			System.Console.Out.WriteLine("Luas Persegi Panjang tersebut adalah {0}",L);
		}
	}
}
