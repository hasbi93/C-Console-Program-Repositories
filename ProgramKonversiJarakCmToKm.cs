using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramKonversiCmToKm{
	struct jarak{
		public double cm,m,km;
	}
	class ProgramKonversiCmToKm{
		public static void Main(string[] args){
			jarak j;
			double input=0, sisa=0;
			System.Console.Out.WriteLine("Masukkan Jarak dalam CM yang ingin dikonversi: ");
			input=System.Convert.ToDouble(System.Console.In.ReadLine());
			j.km=input/100000;
			sisa=input%100000;
			j.m=sisa/100;
			j.cm=sisa%100;
			System.Console.Out.WriteLine("Hasil Konversi: {0} Km, {1} M, {2}Cm ",j.km,j.m,j.cm);
		}
	}
}