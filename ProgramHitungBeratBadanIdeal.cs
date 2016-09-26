using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramHitungBeratBadan{
	struct badan{
		public double berat,tinggi;
	}
	class ProgramHitungBeratBadan{
		public static void Main(string[] args){
			badan b;
			System.Console.Out.WriteLine("Masukkan Tinggi Badan Anda: ");
			b.tinggi=System.Convert.ToDouble(System.Console.In.ReadLine());
			b.berat=(b.tinggi-100)-((b.tinggi-100)*0.1);
			System.Console.Out.WriteLine("Berat Ideal: {0}",b.berat);
		}
	}
}