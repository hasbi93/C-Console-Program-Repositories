using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramIdentifikasiBilanganTerbesar{
	struct Bilangan{
		public int x,y,z;
	}
	class ProgramIdentifikasiBilanganTerbesar{
		public static void Main(string[] args){
			Bilangan B;
			System.Console.Out.WriteLine("Masukkan 3 Bilangan yang Ingin Dibandingkan Secara Berurutan: ");
			B.x=System.Convert.ToInt32(System.Console.In.ReadLine());
			B.y=System.Convert.ToInt32(System.Console.In.ReadLine());
			B.z=System.Convert.ToInt32(System.Console.In.ReadLine());
			if ((B.x>=B.y)&&(B.x>=B.z)){
				System.Console.Out.WriteLine("{0} adalah Bilangan Terbesar.",B.x);
			} else if ((B.y>=B.x)&&(B.y>=B.z)){
				System.Console.Out.WriteLine("{0} adalah Bilangan Terbesar.",B.y);
			} else {
				System.Console.Out.WriteLine("{0} adalah Bilangan Terbesar.",B.z);
			}
		}
	}
}