using System;
using System.Collections.Generic;
using System.Text;

namespace HitungMundurRoket
	{
		class HitungMundur	
			{
				public static void Main(string[] args)
					{
						int i=100;
						while (i>=0)
							{
								System.Console.Out.WriteLine("{0} \n",i);
								i=i-1;
							}
						System.Console.Out.WriteLine("Go!! Rocket Launched!! \n");
					}
			}
	}