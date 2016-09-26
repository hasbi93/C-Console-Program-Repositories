using System;
using System.Collections.Generic;
using System.Text;

namespace CountAddition1toN
{
	class Count 
		{
			public static void Main(string[] args)
				{
					uint i=1,j=0,n=0;
					System.Console.Out.WriteLine("Masukkan Jumlah Pengulangan yang Anda Inginkan: \n");
					n=System.Convert.ToUInt32(System.Console.In.ReadLine());
					do
					{
						j=j+i;
						i=i+1;
					}while(i<=n);
					System.Console.Out.WriteLine("Jumlah = {0} \n",j);
				}
		}
}