using System;
using System.Collections.Generic;
using System.Text;

namespace ForCetakNx
	{
		class ForCetak
			{
				public static void Main(string[] args)
					{
						uint i=0,n=0;
						System.Console.Out.WriteLine("Masukkan N Pengulangan: \n ");
						n=Convert.ToUInt32(System.Console.In.ReadLine());
						for (i=1; i<=n ; i=i+1)
							{
								System.Console.Out.WriteLine("{0} \n",i);
							}
					}
			}
	}