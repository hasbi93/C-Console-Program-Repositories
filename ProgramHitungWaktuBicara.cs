using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramHitungWaktuBicara{
	class ProgramHitungWaktuBicara{
		public static void Main(string[] args){
			System.Console.Out.WriteLine("Masukkan Lama Waktu Bicara Anda (dalam Detik): ");
			int j=0,m=0,d=0,sisa=0,detik=0;
			detik=System.Convert.ToInt32(System.Console.In.ReadLine());
			j=detik/3600;
			sisa=detik%3600;
			m=sisa/60;
			d=sisa%60;
			System.Console.Out.WriteLine("Waktu Bicara Anda adalah {0} Jam: {1} Menit: {2} Detik",j,m,d);
		}
	}
}