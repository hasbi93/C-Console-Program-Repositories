using System;
using System.Collections.Generic;
using System.Text;

namespace WhileCetakAngka
	{
		class CetakAngka
			{
				public static void Main(string[] args)
					{
						uint i=1;
						while (i<=10)
							{
								System.Console.Out.WriteLine("{0} \n",i);
								i=i+1;
							}
					}
			}
	}