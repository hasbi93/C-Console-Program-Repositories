using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramConsoleHitungDeretBilanganBulatGanjilPositifSejumlahN
{
	class ProgramConsoleHitungDeretBilanganBulatGanjilPositifSejumlahN
	{
		public static void Main(string[] args)
		{
			uint i=1,n=0,j=0;
			System.Console.Out.WriteLine("Program Console Penghitung Deret Bilangan Bulat Ganjil Tak Hingga Positif Sejumlah N \n");
			System.Console.Out.WriteLine("Masukkan N Pengulangan yang Anda Inginkan: \n");
			n=Convert.ToUInt32(System.Console.In.ReadLine());
			while(j<(n*n))
			{
				j=j+i;
				i=i+2;
				System.Console.Out.WriteLine("Jumlah Sementara= {0} \n",j);
			}
			System.Console.Out.WriteLine("Jumlah Total Deret= {0} \n",j);
		}
	}
}