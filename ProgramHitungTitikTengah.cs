using System;
using System.Collections.Generic;
using System.Text;

namespace HitungTitikTengah
{
	struct Titik
			{
			public double x,y;
			};
	public class HitungTitikTengah
	{
		public static void Main(string[] args)
		{
			Titik P1,P2,P3;
			System.Console.Out.WriteLine("Masukkan P1.x dan P1.y secara berurutan: ");
			P1.x=System.Convert.ToDouble(System.Console.In.ReadLine());
			P1.y=System.Convert.ToDouble(System.Console.In.ReadLine());
			System.Console.Out.WriteLine("Masukkan P2.x dan P2.y secara berurutan: ");
			P2.x=System.Convert.ToDouble(System.Console.In.ReadLine());
			P2.y=System.Convert.ToDouble(System.Console.In.ReadLine());
			P3.x=(P1.x+P2.x)/2;
			P3.y=(P1.y+P2.y)/2;
			System.Console.Out.WriteLine("P3.x= {0} P3.y= {1}",P3.x,P3.y);
		}
	}
}