using System;
using System.Collections.Generic;
using System.Text;

namespace WhileHitungJumlahDeret
	{
		class HitungDeret
			{
				public static void Main(string[] args)
					{
						uint i=1,j=0,n=0;
						System.Console.Out.WriteLine("Masukkan N Perulangan: \n");
						n=System.Convert.ToUInt32(System.Console.In.ReadLine());
						while(i<=n)
							{
								System.Console.Out.WriteLine("i = {0}, j = {1} \n",i,j);
								j=j+i;
								i=i+1;
							}
					}
			}
	}