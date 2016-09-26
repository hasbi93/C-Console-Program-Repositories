using System;
using System.Collections.Generic;
using System.Text;

namespace WhileCetak1toN
	{
		class OnetoN
			{
				public static void Main(string[] args)
					{
						uint i=1,n=0;
						System.Console.Out.WriteLine("Masukkan N Perulangan: \n");
						n=System.Convert.ToUInt32(System.Console.In.ReadLine());
						while(i<=n)
							{
								System.Console.Out.WriteLine("{0} \n",i);
								i=i+1;
							}
					}
			}
	}
	