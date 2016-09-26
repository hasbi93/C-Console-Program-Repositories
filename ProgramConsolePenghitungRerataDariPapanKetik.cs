using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramConsolePenghitungRerata
{
	class PenghitungRerata
	{
		public static void Main(string[] args)
			{
				uint i=0,j=0,x=0;
				double r=0;
				System.Console.Out.WriteLine("Program Console Penghitung Rerata \n");
				System.Console.Out.WriteLine("Masukkan Angka yang Ingin Anda Jumlahkan: \n");
				x=System.Convert.ToUInt32(System.Console.In.ReadLine());
				while(x!=0)
				{
					i=i+1;
					j=j+x;
					System.Console.Out.WriteLine("Masukkan Angka yang Ingin Anda Jumlahkan: \n");
					System.Console.Out.WriteLine("Masukkan Angka 0 Jika Ingin Menghentikan Operasi: \n");
					x=System.Convert.ToUInt32(System.Console.In.ReadLine());
				}
				if(i!=0)
				{
					r=(double)j/(double)i;
					System.Console.Out.WriteLine("Rerata = {0}",r);
				}
				else
				{
					System.Console.Out.WriteLine("Input Anda Salah atau Tidak Ada Angka Dimasukkan. \n");
				}
			}
	}
}