using System;
using System.Collections.Generic;
using System.Text;

namespace CetakDataSejumlahN
{
	class CetakInputData
	{
		public static void Main(string[] args)
			{
				uint i=0,n=0;
				string c;
				System.Console.Out.WriteLine("Program Console Cetak Input pada Layar \n");
				System.Console.Out.WriteLine("Masukkan Jumlah N Pengulangan Input Cetak yang Anda Inginkan: \n");
				n=System.Convert.ToUInt32(System.Console.In.ReadLine());
				for(i=0;i<=n;i++)
				{
					System.Console.Out.WriteLine("Masukkan Karakter yang Akan DiCetak: \n");
					c=System.Console.In.ReadLine();
					System.Console.Out.WriteLine("Karakter yang Di-Input adalah = {0} \n",c);
					i=i+1;
				}
			}
	}
}