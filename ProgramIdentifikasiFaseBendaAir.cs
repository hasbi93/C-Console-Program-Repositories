using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramIdentifikasiWujudAir{
	struct Suhu{
		public int air;
	}
	struct Wujud{
		public string padat,cair,gas;
	}
	class ProgramIdentifikasiWujudAir{
		public static void Main(string[] args){
			Suhu s;
			Wujud w;
			w.padat="Fase Padat";
			w.cair="Fase Cair";
			w.gas="Fase Gas";
			System.Console.Out.WriteLine("Masukkan Suhu Air (dalam Celsius) untuk Mengetahui Fase Bendanya: ");
			s.air=System.Convert.ToInt32(System.Console.In.ReadLine());
			if (s.air>=100){
				System.Console.Out.WriteLine(w.gas);
			} else if(s.air<=0){
				System.Console.Out.WriteLine(w.padat);
			} else {
				System.Console.Out.WriteLine(w.cair);
			}
		}
	}
}