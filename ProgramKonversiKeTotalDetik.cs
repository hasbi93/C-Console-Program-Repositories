using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramKonversiKeDetik{
	struct Jam{
		public int hh,mm,ss;
	};
	class ProgramKonversiKeDetik{
		public static void Main(string[] args){
			Jam J;
			int TotalDetik=0;
			System.Console.Out.WriteLine("Masukkan Jam,Menit,Detik Secara Berurutan: ");
			J.hh=System.Convert.ToInt32(System.Console.In.ReadLine());
			J.mm=System.Convert.ToInt32(System.Console.In.ReadLine());
			J.ss=System.Convert.ToInt32(System.Console.In.ReadLine());
			TotalDetik=(J.hh*3600)+(J.mm*60)+J.ss;
			System.Console.Out.WriteLine("Total Detik= {0}",TotalDetik);
		}
	}
}