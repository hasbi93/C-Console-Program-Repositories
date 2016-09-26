using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramKonversiDetikKeJam{
	struct jam{
		public int hh1;
		public int mm1;
		public int ss1;
	}
	class ProgramKonversiDetikKeJam{
		public static void Main(string[] args){
				jam j;
				int input=0,sisa=0;
				System.Console.Out.WriteLine("Masukkan Jumlah Detik yang Ingin Anda Konversi: ");
				input=System.Convert.ToInt32(System.Console.In.ReadLine());
				j.hh1=input/3600;
				sisa=input%3600;
				j.mm1=sisa/60;
				j.ss1=sisa%60;
				System.Console.Out.WriteLine("{0} Jam: {1} Menit: {2} Detik",j.hh1,j.mm1,j.ss1);
		}
	}
}