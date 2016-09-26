using System;
using System.Collections.Generic;
using System.Text;

namespace Repeat1to10
{
	class Repeat1to10
		{
			public static void Main(string[] args)
				{
					uint i=1;
					do
						{
							System.Console.Out.WriteLine("{0} \n",i);
							i=i+1;
						}while(i<=10);
				}
		}
}