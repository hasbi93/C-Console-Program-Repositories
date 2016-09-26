using System;
using System.Collections.Generic;
using System.Text;

namespace ForJumlahDeretSederhana
	{
		class jumlahderet
			{
				public static void Main(string[] args)
					{
						uint i=0,n=0,j=0;
						j=0;
						System.Console.Out.WriteLine("Masukkan N Pengulangan: ");
						n=System.Convert.ToUInt32(System.Console.In.ReadLine());
						for (i=1; i<=n; i=i+1)
							{
								j=j+i;
								System.Console.Out.WriteLine("{0} \n",j);
							}
						
					}
			}
	}