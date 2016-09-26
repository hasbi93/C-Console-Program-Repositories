using System;
using System.Collections.Generic;
using System.Text;

namespace testRomawi{
	struct Pecahan{
		public int i,v,x,l,c,d,m;
	}
	class testRomawi{
		public static void Main(string[] args){
			Pecahan p;
			p.i=0;
			p.v=0;
			p.x=0;
			p.l=0;
			p.c=0;
			p.d=0;
			p.m=0;
			int input=0,sisa=0;
			System.Console.Out.WriteLine("Masukkan Angka Latin yang Ingin DiKonversi Ke Angka Romawi: ");
			input=System.Convert.ToInt32(System.Console.In.ReadLine());
			p.m=input/1000;
			sisa=input%1000;
			p.d=sisa/500;
			sisa=sisa%500;
			p.c=sisa/100;
			sisa=sisa%100;
			p.l=sisa/50;
			sisa=sisa%50;
			p.x=sisa/10;
			sisa=sisa%10;
			p.v=sisa/5;
			p.i=sisa%5;
			System.Console.Out.WriteLine("{0} m {1} d {2} c {3} l {4} x {5} v {6} I",p.m,p.d,p.c,p.l,p.x,p.v,p.i);
		}
	}
}




