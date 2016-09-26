using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramIdentifikasiModulo4{
	class ProgramIdentifikasiModulo4{
		public static void Main(string[] args){
			int input=0;
			System.Console.Out.WriteLine("Masukkan Angka yang Ingin Diuji Kelipatan 4-nya: ");
			input=System.Convert.ToInt32(System.Console.In.ReadLine());
			if (input%4==0){
				System.Console.Out.WriteLine("Kelipatan Empat.");
			} else {
				System.Console.Out.WriteLine("Bukan Kelipatan Empat.");
			}
		}
	}
}