using System;
using System.Collections.Generic;
using System.Text;

namespace HitungPecahanRupiah{
	struct pecahan{
		public int satu,dualima,limapuluh,seratus,limaratus,seribu;
	};
	class HitungPecahanRupiah{
		public static void Main(string[] args){
			pecahan p;
			int input=0,sisa=0;
			System.Console.Out.WriteLine("Masukkan Jumlah Uang yang Ingin Dipecah: ");
			input=System.Convert.ToInt32(System.Console.In.ReadLine());
			p.seribu=input/1000;
			sisa=input%1000;
			p.limaratus=sisa/500;
			sisa=sisa%500;
			p.seratus=sisa/100;
			sisa=sisa%100;
			p.limapuluh=sisa/50;
			sisa=sisa%50;
			p.dualima=sisa/25;
			p.satu=sisa%25;
			System.Console.Out.WriteLine("Jumlah Pecahan= 1000:{0} buah, 500:{1} buah, 100:{2} buah, 50:{3} buah, 25:{4} buah, 1:{5} buah",p.seribu,p.limaratus,p.seratus,p.limapuluh,p.dualima,p.satu);
		}
	}
}