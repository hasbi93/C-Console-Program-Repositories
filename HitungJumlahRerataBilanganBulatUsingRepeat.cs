using System;
using System.Collections.Generic;
using System.Text;

namespace HitungRerataDeretBilanganBulatUsingRepeat
{
	class RepeatMain
		{
			public static void Main(string[] args)
				{
					uint i=1,j=0,n=0,r=0,x=0;
					System.Console.Out.WriteLine("Masukkan Nilai N Pengulangan yang Anda Inginkan: \n");
					n=System.Convert.ToUInt32(System.Console.In.ReadLine());
					do
					{
						System.Console.Out.WriteLine("Masukkan Bilangan Bulat yang Ingin Anda Jumlahkan: \n");
						x=System.Convert.ToUInt32(System.Console.In.ReadLine());
						j=j+x;
						i=i+1;
						System.Console.Out.WriteLine("Jumlah Sementara = {0} \n",j);
					}while(i<=n);
					r=j/n;
					System.Console.Out.WriteLine("Jumlah Rerata = {0} \n",r);
				}
		}
}