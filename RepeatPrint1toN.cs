using System;
using System.Collections.Generic;
using System.Text;

namespace RepeatPrint1toN
{
	class Repeat 
		{
			public static void Main(string[] args)
				{
					uint i=1,n=0;
					System.Console.Out.WriteLine("Masukkan Jumlah Perulangan yang Anda Inginkan: \n");
					n=System.Convert.ToUInt32(System.Console.In.ReadLine());
					do
					{
						System.Console.Out.WriteLine("{0} \n",i);
						i=i+1;
					}while(i<=n);
				}
		}
}