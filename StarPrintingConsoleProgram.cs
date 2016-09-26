using System;
using System.Collections.Generic;
using System.Text;

namespace StarPrintingConsoleProgram
{
	class StarPrinting
	{
		public static void Main(string[] args)
			{
				uint i=1,j=0,n=0;
				System.Console.Out.WriteLine("Star Printing Console Program \n");
				System.Console.Out.WriteLine("Masukkan Jumlah Pengulangan N yang Anda Inginkan Untuk Mencetak The Star Sign (*) \n");
				n=System.Convert.ToUInt32(System.Console.In.ReadLine());
				for(i=1;i<=n;i++)
				{
					for(j=1;j<=i;++i)
						{
							Console.WriteLine("* ");
						}
					Console.WriteLine(" ");
				}
			}
	}
}
