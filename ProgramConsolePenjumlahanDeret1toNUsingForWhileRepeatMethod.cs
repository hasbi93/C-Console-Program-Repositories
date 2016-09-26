using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramConsolePenjumlahanDeretUsingForWhileRepeatMethod
{
	class ForRepeatWhile
	{
		public static void Main(string[] args)
			{
				uint i=1,j=0,n=0;
				System.Console.Out.WriteLine("Program Penjumlahan Deret Using For Method \n");
				System.Console.Out.WriteLine("Masukkan N Pengulangan yang Anda Inginkan: \n");
				n=System.Convert.ToUInt32(System.Console.In.ReadLine());
				for(i=1;i<=n;i=i++)
					{
						j=j+i;
						i=i+1;
					}
				System.Console.Out.WriteLine("Jumlah Deret = {0} \n",j);
				System.Console.Out.WriteLine("Program Penjumlahan Deret Using While Method \n");
				System.Console.Out.WriteLine("Masukkan N Pengulangan yang Anda Inginkan: \n");
				n=System.Convert.ToUInt32(System.Console.In.ReadLine());
				j=0;
				i=1;
				while(i<=n && i>=0)
					{
						j=j+i;
						i=i+1;
					}
				System.Console.Out.WriteLine("Jumlah Deret = {0} \n",j);
				System.Console.Out.WriteLine("Program Penjumlahan Deret Using Repeat Method \n");
				System.Console.Out.WriteLine("Masukkan N Pengulangan yang Anda Inginkan: \n");
				n=System.Convert.ToUInt32(System.Console.In.ReadLine());
				j=0;
				i=1;
				do
					{
						j=j+i;
						i=i+1;
					}while(i<=n && i>=0);
				System.Console.Out.WriteLine("Jumlah Deret = {0} \n",j);
			}
	}
}