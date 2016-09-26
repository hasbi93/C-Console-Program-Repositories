using System;
using System.Collections.Generic;
using System.Text;

namespace HitungRerataModdariPapan
	{
		class HitungRerataMod 
			{
				public static void Main(string[] args)
					{
						uint i=1,j=0,m=0,n=0,r=0,x=0;
						System.Console.Out.WriteLine("Masukkan N Perulangan: \n");
						n=System.Convert.ToUInt32(System.Console.In.ReadLine());
						while (i<=n)
							{
								System.Console.Out.WriteLine("Masukkan Angka yang Anda Inginkan: \n");
								x=System.Convert.ToUInt32(System.Console.In.ReadLine());
								System.Console.Out.WriteLine("i = {0} , j = {1} \n");
								j=j+x;
								i=i+1;
							}
						r=j/n;
						m=j%n;
						System.Console.Out.WriteLine("Total J = {0} \n",j);
						System.Console.Out.WriteLine("Rerata ({0}/{1} = {2}, Mod ({3} mod {4}) = {5} \n",j,n,r,j,n,m);
					}
			}
	}