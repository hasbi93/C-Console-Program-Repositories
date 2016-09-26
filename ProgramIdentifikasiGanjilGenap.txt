using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramIdentifikasiGenapGanjil{
	struct GenapGanjil{
		public int x;
	}
	class ProgramIdentifikasiGenapGanjil{
		public static void Main(string[] args){
			GenapGanjil G;
			System.Console.Out.WriteLine("Masukkan Angka yang Ingin Diketahui Ganjil Genap-nya: ");
			G.x=System.Convert.ToInt32(System.Console.In.ReadLine());
			if ((G.x % 2)==0){
				System.Console.Out.WriteLine("Bilangan Genap");
			} else {
				System.Console.Out.WriteLine("Bilangan Ganjil");
			}
		}
	}
}