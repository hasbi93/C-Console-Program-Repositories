using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramHitungTahunKabisat{
	struct Tahun{
		public int t;
	}
	class ProgramHitungTahunKabisat{
		public static void Main(string[] args){
			Tahun t;
			System.Console.Out.WriteLine("Masukkan Tahun yang Ingin Diketahui Ke-Kabisat-annya: ");
			t.t=System.Convert.ToInt32(System.Console.In.ReadLine());
			if (((t.t%4==0)&&(t.t%100!=0))||(t.t%400==0)){
				bool result=(true);
				System.Console.Out.WriteLine(result?"Tahun Kabisat":"Tahun Non Kabisat");
			} else {
				bool result=(false);
				System.Console.Out.WriteLine(result?"Tahun Kabisat":"Tahun Non Kabisat");
			}
		}
	}
}