using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramSapaSederhana{
	class ProgramSapaSederhana{
		public static void Main(string[] args){
			string nama;
			System.Console.Out.WriteLine("Masukkan Nama Anda: ");
			nama=System.Convert.ToString(System.Console.In.ReadLine());
			System.Console.Out.WriteLine("Senang Bertemu Denganmu {0}",nama);
		}
	}
}