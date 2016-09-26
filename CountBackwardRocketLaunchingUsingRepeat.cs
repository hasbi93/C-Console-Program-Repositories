using System;
using System.Collections.Generic;
using System.Text;

namespace RocketCountDown
{
	class CountDown
		{
			public static void Main(string[] args)
				{
					uint i =100;
					do
					{
						System.Console.Out.WriteLine("{0} \n \a",i);
						i=i-1;
					}while(i>0);
					System.Console.Out.WriteLine("Go!! Rocket Lauched!! \n");
				}
		}
}