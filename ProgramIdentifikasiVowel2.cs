using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramIdentifikasiVowel2{
	struct vowel{
		public string a,i,u,e,o;
	}
	class ProgramIdentifikasiVowel2{
		public static void Main(string[] args){
			vowel v;
			v.a="a";
			v.i="i";
			v.u="u";
			v.e="e";
			v.o="o";
			string input;
			System.Console.Out.WriteLine("Masukkan Huruf Untuk Mengetahui Vowel-nya: ");
			input=System.Convert.ToString(System.Console.In.ReadLine());
			bool result=input.Equals(v.a,StringComparison.OrdinalIgnoreCase);
			if (result==(true)){
				System.Console.Out.WriteLine(result?"vowel":"not vowel");
			}
			bool result2=input.Equals(v.i,StringComparison.OrdinalIgnoreCase);
			if(result2==(true)) {
				System.Console.Out.WriteLine(result2?"vowel":"not vowel");
			}
			bool result3=input.Equals(v.u,StringComparison.OrdinalIgnoreCase);
			if (result3==(true)) {
				System.Console.Out.WriteLine(result3?"vowel":"not vowel");
			}
			bool result4=input.Equals(v.e,StringComparison.OrdinalIgnoreCase);
			if (result4==(true)){
				System.Console.Out.WriteLine(result4?"vowel":"not vowel");
			}
			bool result5=input.Equals(v.o,StringComparison.OrdinalIgnoreCase);
			if (result5==(true)) {
				System.Console.Out.WriteLine(result5?"vowel":"not vowel");
			} 
			if ((result||result2||result3||result4||result5)==(false)){
				System.Console.Out.WriteLine("not vowel");
			}
		}
	}
}
