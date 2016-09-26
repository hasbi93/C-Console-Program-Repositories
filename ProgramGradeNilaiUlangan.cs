using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramGradeNilaiUlangan{
	struct Grade{
		public string A,B,C,D,E;
	}
	class ProgramGradeNilaiUlangan{
		public static void Main(string[] args){
			Grade g;
			double input=0;
			System.Console.Out.WriteLine("Masukkan Nilai Ujian Anda: \n(Nilai Ujian Anda Akan Langsung DiKonversi Dalam Bentuk Huruf)");
			input=System.Convert.ToInt32(System.Console.In.ReadLine());
			if (input>=80){
				g.A="A";
				System.Console.Out.WriteLine(g.A);
			} else if ((input<=80)&&(input>=70)){
				g.B="B";
				System.Console.Out.WriteLine(g.B);
			} else if ((input<=70)&&(input>=55)){
				g.C="C";
				System.Console.Out.WriteLine(g.C);
			} else if ((input<=55)&&(input>=40)){
				g.D="D";
				System.Console.Out.WriteLine(g.D);
			} else if (input<=40){
				g.E="E";
				System.Console.Out.WriteLine(g.E);
			} else {
				System.Console.Out.WriteLine("Maaf Input yang Anda Masukkan Salah.");
			}
		}
	}
}