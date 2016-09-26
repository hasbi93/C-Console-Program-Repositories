using System;
using System.Collections.Generic;
using System.Text;

namespace HitungSelisihTanggal{
	struct tanggal{
		public int yya,mma,dda,yyb,mmb,ddb,yyc,mmc,ddc;
	}
	class HitungSelisihTanggal{
		public static void Main(string[] args){
			tanggal t;
			int totalhari1=0,totalhari2=0,totalhari3=0,sisa=0;
			System.Console.Out.WriteLine("Masukkan yy1:mm1:dd1 secara berurutan:  ");
			t.yya=System.Convert.ToInt32(System.Console.In.ReadLine());
			t.mma=System.Convert.ToInt32(System.Console.In.ReadLine());
			t.dda=System.Convert.ToInt32(System.Console.In.ReadLine());
			totalhari1=(t.yya*365)+(t.mma*30)+t.dda;
			System.Console.Out.WriteLine("Masukkan yy2:mm2:dd2 secara berurutan: ");
			t.yyb=System.Convert.ToInt32(System.Console.In.ReadLine());
			t.mmb=System.Convert.ToInt32(System.Console.In.ReadLine());
			t.ddb=System.Convert.ToInt32(System.Console.In.ReadLine());
			totalhari2=(t.yyb*365)+(t.mmb*30)+t.ddb;
			totalhari3=totalhari2-totalhari1;
			t.yyc=totalhari3/356;
			sisa=totalhari3%365;
			t.mmc=sisa/30;
			t.ddc=sisa%30;
			System.Console.Out.WriteLine("Selisih Hari: {0} Tahun: {1} Bulan: {2} Hari ",t.yyc,t.mmc,t.ddc);
		}
	}
}