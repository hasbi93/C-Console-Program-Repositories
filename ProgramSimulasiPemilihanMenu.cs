using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramSimulasiPemilihanMenu
{
	class Simulasi
		{
			public static void Main(string[] args)
				{
					uint nomormenu=0;
					System.Console.Out.WriteLine("Program Simulasi Pemilihan Nomor Menu \n");
					do
					{
						System.Console.Out.WriteLine("MENU \n");
						System.Console.Out.WriteLine("1.Baca Data \n");
						System.Console.Out.WriteLine("2.Ubah Data \n");
						System.Console.Out.WriteLine("3.Cetak Data \n");
						System.Console.Out.WriteLine("4.Hapus Data \n");
						System.Console.Out.WriteLine("5. Keluar Program \n");
						nomormenu=System.Convert.ToUInt32(System.Console.In.ReadLine());
						switch(nomormenu)
						{
							case 1:System.Console.Out.WriteLine("Anda Memilih Menu Nomor 1 \n");break;
							case 2:System.Console.Out.WriteLine("Anda Memilih Menu Nomor 2 \n");break;
							case 3:System.Console.Out.WriteLine("Anda Memilih Menu Nomor 3 \n");break;
							case 4:System.Console.Out.WriteLine("Anda Memilih Menu Nomor 4 \n");break;
							case 5:System.Console.Out.WriteLine("Keluar Program \n");break;
							default:Console.WriteLine("Input Salah \n");break;
						}
					}while(nomormenu!=5);
				}
		}
}