using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramIdentifikasiVowel{
	struct vowel{
		public string a;
	}
	class ProgramIdentifikasiVowel{
		public static void Main(string[] args){
			vowel v;
			v.a="a";
			string input;
			System.Console.Out.WriteLine("Masukkan Huruf yang Ingin DiIdentifikasi: ");
			input=System.Convert.ToString(System.Console.In.ReadLine());
			bool result=input.Equals(v.a,StringComparison.OrdinalIgnoreCase);
			System.Console.Out.WriteLine("Ordinal Comparison are {0}",result?"Equal":"Not Equal");
		}
	}
}
