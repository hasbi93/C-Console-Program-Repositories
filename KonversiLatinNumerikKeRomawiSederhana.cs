using System;
using System.Collections.Generic;
using System.Text;

namespace KonversiLatinNumerikKeRomawiSederhana
	{
		struct rom
			{
				public uint i,v,x,l,c,d,m;
			};
	
		class Konversi 
			{
				public static void Main(string[] args)
					{
							rom r;
							uint angka=0,sisa=0,sisa2=0,sisa3=0,sisa4=0,sisa5=0;
							Console.Out.WriteLine("Masukkan Angka yang Ingin Anda Konversi ke Angka Romawi.");
							angka=Convert.ToUInt32(Console.In.ReadLine());
							r.m=angka/1000;
							sisa=angka%1000;
							r.d=sisa/500;
							sisa2=sisa%500;
							r.c=sisa2/100;
							sisa3=sisa2%100;
							r.l=sisa3/50;
							sisa4=sisa3%50;
							r.x=sisa4/10;
							sisa5=sisa4%10;
							r.v=sisa5/5;
							r.i=sisa5%5;
							
							Console.Out.WriteLine("{0} M {1} D {2} C {3} L {4} X {5} V {6} I ",r.m,r.d,r.c,r.l,r.x,r.v,r.i);
							
					}
					
			}
	}