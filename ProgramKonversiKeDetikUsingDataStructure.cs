using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramKonversiKeDetikUsingDataStructure{
	struct Jam{
		public int hh,mm,ss;
	};
	class ProgramKonversiKeDetikUsingDataStructure{
		public static void Main(string[] args){
			Jam J;
			int sisa=0,totaldetik=0;
			System.Console.Out.WriteLine("Masukkan Jumlah Detik yang Ingin Anda Konversi Ke Waktu Normal: ");
			totaldetik=System.Convert.ToInt32(System.Console.In.ReadLine());
			J.hh=totaldetik/3600;
			sisa=totaldetik%3600;
			J.mm=sisa/60;
			J.ss=sisa%60;
			System.Console.Out.WriteLine("Durasi= {0} Jam, {1} Menit, {2} Detik",J.hh,J.mm,J.ss);
		}
	}
}