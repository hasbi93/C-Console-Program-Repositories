using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramIdentifikasiKarakterAngka1to9{
	struct Angka{
		public char a,b,c,d,e,f,g,h,i,j;
	}
	class ProgramIdentifikasiKarakterAngka1to9{
		public static void Main(string[] args){
			Angka a;
			a.a='0';
			a.b='1';
			a.c='2';
			a.d='3';
			a.e='4';
			a.f='5';
			a.g='6';
			a.h='7';
			a.i='8';
			a.j='9';
			int input=0;
			System.Console.Out.WriteLine("Masukkan Angka antara 0-9 untuk Mencataknya Ke Layar: ");
			input=System.Convert.ToInt32(System.Console.In.ReadLine());
			switch (input){
				case 0:{
					System.Console.Out.WriteLine(a.a);
					break;
				}
				case 1:{
					System.Console.Out.WriteLine(a.b);
					break;
				}
				case 2:{
					System.Console.Out.WriteLine(a.c);
					break;
				}
				case 3:{
					System.Console.Out.WriteLine(a.d);
					break;
				}
				case 4:{
					System.Console.Out.WriteLine(a.e);
					break;
				}
				case 5:{
					System.Console.Out.WriteLine(a.f);
					break;
				}
				case 6:{
					System.Console.Out.WriteLine(a.g);
					break;
				}
				case 7:{
					System.Console.Out.WriteLine(a.h);
					break;
				}
				case 8:{
					System.Console.Out.WriteLine(a.i);
					break;
				}
				case 9:{
					System.Console.Out.WriteLine(a.j);
					break;
				}
				default:{
					System.Console.Out.WriteLine("Error");
					break;
				}
			}
		}
	}
}