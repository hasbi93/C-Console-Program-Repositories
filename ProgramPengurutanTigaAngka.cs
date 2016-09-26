using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramPengurutTigaAngka{
	struct angka{
		public int x,y,z,maks,min,med;
	}
	class ProgramPengurutTigaAngka{
		public static void Main(string[] args){
			angka a;
			System.Console.Out.WriteLine("Masukkan Tiga Angka yang Anda Ingin Urutkan: ");
			a.x=System.Convert.ToInt32(System.Console.In.ReadLine());
			a.y=System.Convert.ToInt32(System.Console.In.ReadLine());
			a.z=System.Convert.ToInt32(System.Console.In.ReadLine());
			if ((a.x>=a.y)&&(a.x>=a.z)){
				a.maks=a.x;
			} else if ((a.y>=a.x)&&(a.y>=a.z)){
				a.maks=a.y;
				} else {
					a.maks=a.z;
			}
			if ((a.x<=a.y)&&(a.x<=a.z)){
				a.min=a.x;
			} else if ((a.y<=a.x)&&(a.y<=a.z)){
				a.min=a.y;
			} else {
				a.min=a.z;
			}
			if ((a.x!=a.maks)&&(a.x!=a.min)){
				a.med=a.x;
			} else if((a.y!=a.maks)&&(a.y!=a.min)) {
				a.med=a.y;
			} else {
				a.med=a.z;
			}
			System.Console.Out.WriteLine("{0}>{1}>{2}",a.maks,a.med,a.min);
		}
	}
}