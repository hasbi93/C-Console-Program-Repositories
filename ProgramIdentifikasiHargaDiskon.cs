using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramIdentifikasiHargaDiskon{
	class ProgramIdentifikasiHargaDiskon{
		public static void Main(string[] args){
			double input=0,hargadiskon=0;
			string diskon="10%";
			System.Console.Out.WriteLine("Masukkan Total Nilai Belanja Anda: ");
			input=System.Convert.ToDouble(System.Console.In.ReadLine());
			if (input>=100000){
				hargadiskon=input-(input*0.1);
				System.Console.Out.WriteLine("Total Belanja Anda: {0}, mendapatkan Diskon {1}",hargadiskon,diskon);
			} else {
				System.Console.Out.WriteLine("Total Belanja Anda: {0}",input);
			}
		}
	}
}