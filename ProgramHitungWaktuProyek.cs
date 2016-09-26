using System;
using System.Collections.Generic;
using System.Text;

namespace WaktuProyek{
	struct Waktu{
		public int yy,mm,ww,dd;
	};
	class WaktuProyek{
		public static void Main(string[] args){
			Waktu w;
			int input=0,sisa=0;
			System.Console.Out.WriteLine("Masukkan Durasi Proyek dalam bentuk Hari: ");
			input=System.Convert.ToInt32(System.Console.In.ReadLine());
			w.yy=input/365;
			sisa=input%365;
			w.mm=sisa/30;
			sisa=sisa%30;
			w.ww=sisa/7;
			w.dd=sisa%7;
			System.Console.Out.WriteLine("Durasi Proyek {0} Tahun: {1} Bulan: {2} Minggu: {3} Hari",w.yy,w.mm,w.ww,w.dd);
		}
	}
}