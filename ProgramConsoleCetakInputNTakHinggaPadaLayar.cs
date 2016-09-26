using System;
using System.Collections.Generic;
using System.Text;

namespace CetakInputDenganNTakHingga
{
	class CetakInputDenganNTakHingga
	{
		public static void Main(string[] args)
			{
				uint i=1;
				string c;
				System.Console.Out.WriteLine("Program Console Cetak Input dengan N Tak Hingga \n");
				System.Console.Out.WriteLine("Masukkan Data yang Ingin Anda Tampilkan di Layar: \n");
				c=System.Console.In.ReadLine();
				while(i!=0)
				{
					System.Console.Out.WriteLine("Karakter yang Anda Masukkan adalah: {0} \n",c);
					System.Console.Out.WriteLine("Masukkan Angka 0 Jika Ingin Mengakhiri Program dan Selain 0 Jika Ingin Melanjutkan: \n");
					i=System.Convert.ToUInt32(System.Console.In.ReadLine());
					System.Console.Out.WriteLine("Masukkan Data yang Ingin Anda Cetak di Layar: \n");
					c=System.Console.In.ReadLine();
				}
			}
	}
}