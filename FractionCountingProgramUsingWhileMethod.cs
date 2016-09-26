using System;
using System.Collections.Generic;
using System.Text;

namespace FractionCountingProgram
{
	class Counter
		{
			public static void Main(string[] args)
				{
					uint x;
					double s=0;
					System.Console.Out.WriteLine("Fraction Counting Program \n");
					System.Console.Out.WriteLine("Masukkan x dari 1/x yang Ingin anda jumlahkan: \n");
					x=System.Convert.ToUInt32(System.Console.In.ReadLine());
					while(x!=0)
					{	
						s=s+1/(double)x;
						System.Console.Out.WriteLine("Masukkan x dari 1/x yang Ingin Anda Tambahkan: \n");
						System.Console.Out.WriteLine("Masukkan 0 Untuk Mengakhiri Program: \n");
						x=System.Convert.ToUInt32(System.Console.In.ReadLine());
					}
					System.Console.Out.WriteLine("Jumlah S Total = {0}",s);
				}
		}
}