using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramPenghitungSelisihDuaJam{
	struct Jam{
		public int hha,mma,ssa,hhb,mmb,ssb,hhc,mmc,ssc;
	};
	class ProgramPenghitungSelisihDuaJam{
		public static void Main(string[] args){
			Jam J;
			int TotalDetik=0,TotalDetik1=0,TotalDetik2=0,sisa=0;
			System.Console.Out.WriteLine("Masukkan Waktu Akhir dalam Format (hh:mm:ss) :");
			J.hha=System.Convert.ToInt32(System.Console.In.ReadLine());
			J.mma=System.Convert.ToInt32(System.Console.In.ReadLine());
			J.ssa=System.Convert.ToInt32(System.Console.In.ReadLine());
			TotalDetik1=(J.hha*3600)+(J.mma*60)+(J.ssa);
			System.Console.Out.WriteLine("Masukkan Waktu Awal dalam Format (hh:mm:ss) :");
			J.hhb=System.Convert.ToInt32(System.Console.In.ReadLine());
			J.mmb=System.Convert.ToInt32(System.Console.In.ReadLine());
			J.ssb=System.Convert.ToInt32(System.Console.In.ReadLine());
			TotalDetik2=(J.hhb*3600)+(J.mmb*60)+(J.ssb);
			TotalDetik=TotalDetik1-TotalDetik2;
			J.hhc=TotalDetik/3600;
			sisa=TotalDetik%3600;
			J.mmc=sisa/60;
			J.ssc=sisa%60;
			System.Console.Out.WriteLine("Selisih Waktu: {0} Jam: {1} Menit: {2} Detik",J.hhc,J.mmc,J.ssc);
		}
	}
}