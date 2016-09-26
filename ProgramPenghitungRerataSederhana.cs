using System;
using System.Collections.Generic;
using System.Text;

namespace RerataDeretBilangan
	{
		class RerataDeret
			{
				public static void Main(string[] args)
					{
						uint i=0,j=0,m=0,n=0,r=0,x=0;
						System.Console.Out.WriteLine("Program Penghitung Rerata Masukan: ");
						System.Console.Out.WriteLine("Masukkan N Perulangan: ");
						n=System.Convert.ToUInt32(System.Console.In.ReadLine());
						for(i=1;i<=n;i=i+1)
							{
								System.Console.Out.WriteLine("Masukkan Angka yang Diinginkan: ");
								x=System.Convert.ToUInt32(System.Console.In.ReadLine());
								j=j+x;
								System.Console.Out.WriteLine("Jumlah Sementara: {0}",j);
							}
						r=j/n;
						m=j%n;
						System.Console.Out.WriteLine("Rerata ({0} {1} {2}) = {3} \nMod(%) ({4} {5} {6}) = {7}",j," : ",n,r,j," % ",n,m);
					}
			}
	}