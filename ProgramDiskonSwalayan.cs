using System;
using System.Collections.Generic;
using System.Text;

namespace DiskonSwalayan
	{
	class Diskon 
		{
		public static void Main(string[] args)
			{
				double hargaawal=0,diskon=0.10,hargadiskon=0,hargaakhir=0;
				Console.Out.WriteLine("Masukkan Total Harga Belanjaan Anda:");
				hargaawal=Convert.ToInt32(Console.In.ReadLine());
				if (hargaawal>=100000)
					{
						hargadiskon=hargaawal*diskon;
						hargaakhir=hargaawal-hargadiskon;
						Console.Out.WriteLine("Selamat, Anda Mendapatkan Diskon Sebesar {0}",hargadiskon);
						Console.Out.WriteLine("Total Harga Belanjaan Anda adalah {0}",hargaakhir);
					}
				else
						Console.Out.WriteLine("Maaf, Anda Tidak Mendapatkan Diskon, Total Harga Belanjaan Anda adalah {0}",hargaawal);
				Console.ReadLine();
			}
		}
	}


