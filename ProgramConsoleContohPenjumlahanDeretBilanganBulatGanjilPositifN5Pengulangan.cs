using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramConsoleContohPenghitungDeretBilanganBulatGanjilPositifDenganN5
{
	class ProgramConsoleContohPenghitungDeretBilanganBulatGanjilPositifDenganN5
	{
		public static void Main(string[] args)
		{
			uint i=1,j=0,n=5;
			System.Console.Out.WriteLine("Program Console Contoh Penjumlahan Deret Bilangan Bulat Ganjil Positif Dengan Pengulangan N=5. \n");
			while(j<(n*n))
			{
				j=j+i;
				i=i+2;
				Console.WriteLine("Jumlah Sementara= {0} \n",j);
			}
			System.Console.Out.WriteLine("Jumlah Total Deret={0} \n",j);
		}
	}
}