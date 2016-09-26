using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramIdentifikasiJenisSegitiga{
	struct Segitiga{
		public int a,b,c;
	}
	class ProgramIdentifikasiJenisSegitiga{
		public static void Main(string[] args){
			Segitiga s;
			System.Console.Out.WriteLine("Masukkan sisi a,b, dan c segitiga secara berurutan: ");
			s.a=System.Convert.ToInt32(System.Console.In.ReadLine());
			s.b=System.Convert.ToInt32(System.Console.In.ReadLine());
			s.c=System.Convert.ToInt32(System.Console.In.ReadLine());
			if ((s.a==s.b)&&(s.b==s.c)&&(s.c==s.a)){
				System.Console.Out.WriteLine("Segitiga Sama Sisi");
			} else if ((s.a==s.b)||(s.a==s.c)){
				System.Console.Out.WriteLine("Segitiga Sama Kaki");
			} else if ((s.b==s.a)||(s.b==s.c)){
				System.Console.Out.WriteLine("Segitiga Sama Kaki");
			} else if ((s.c==s.a)||(s.c==s.b)){
				System.Console.Out.WriteLine("Segitiga Sama Kaki");
			} else if ((s.a!=s.b)&&(s.b!=s.c)&&(s.c!=s.a)){
				System.Console.Out.WriteLine("Segitiga Irregular");
			} else {
				System.Console.Out.WriteLine("Maaf Input Anda Salah");
			}
		}
	}	
}