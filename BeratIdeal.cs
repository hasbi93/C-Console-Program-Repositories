using System;
using System.Collections.Generic;
using System.Text;

namespace BeratIdeal
	{
		class Berat_Ideal
				public static void Main(string[]args)
			{
					{	
						Double berat=0,berat0=0,tinggi=0,tinggi0=0;
						Console.Out.WriteLine("Untuk Mengetahui Berat Ideal Anda, Masukkan Tinggi Badan Anda: ");
						tinggi=Convert.ToDouble(Console.In.ReadLine());
						Console.Out.WriteLine("Masukkan Berat Badan Anda: ");
						berat=Convert.ToDouble(Console.In.ReadLine());
						tinggi0=tinggi-100;
						berat0=tinggi0-(tinggi0*0.1);
						Console.Out.WriteLine("Berat Ideal Anda Adalah: {0} Kg.",berat0);
						if (berat<=(berat0+2)&&berat>=(berat0-2))
							{
								Console.Out.WriteLine("Berat Badan Anda Sudah Ideal.");
							}
						else 
							{
								Console.Out.WriteLine("Berat Badan Anda Belum Ideal.");
							}
					}
			}
	}