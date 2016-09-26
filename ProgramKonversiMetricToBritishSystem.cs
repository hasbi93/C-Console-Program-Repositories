using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramKonversiMetricToBritishSystem{
	struct Konversi{
		public double yard,inch,feet;
	}
	class ProgramKonversiMetricToBritishSystem{
		public static void Main(string[] args){
			Konversi k;
			double input=0, sisa=0;
			System.Console.Out.WriteLine("Masukkan Jarak dalam Meter yang Ingin Anda Konversi ke British System: ");
			input=System.Convert.ToDouble(System.Console.In.ReadLine());
			k.yard=input*0.9144;
			sisa=input%0.9144;
			System.Console.Out.WriteLine("Mod Yard: {0}",sisa);
			k.feet=sisa*0.3048;
			sisa=sisa%0.3048;
			k.inch=sisa*0.0254;
			System.Console.Out.WriteLine("Hasil Konversi: {0} Yard, {1} Feet, {2} Inch",k.yard,k.feet,k.inch);
		}
	}
}