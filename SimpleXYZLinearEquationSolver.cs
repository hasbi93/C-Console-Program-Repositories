using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleXYZLinearEquationSolver
{
	class SimpleXYZLinearEquationSolver
	{
		public static void Main(string[] args)
		{
			uint n=0, x=0, y=0, z=0;
			System.Console.Out.WriteLine("Program Console Simple XYZ Linear Equation Solver \n");
			System.Console.Out.WriteLine("x+y+z=n; Insert N= \n");
			n=System.Convert.ToUInt32(System.Console.In.ReadLine());
			System.Console.Out.WriteLine("X,Y,Z Probability= \n");
			for(x=0;x<=n;x++)
			{
				System.Console.Out.WriteLine("X= {0}",x);
			}
			for(y=0;y<=n;y++)
			{
				System.Console.Out.WriteLine("Y= {0}",y);
			}
			for(z=0;z<=n;z++)
			{
				System.Console.Out.WriteLine("Z= {0}",z);
			}
		}
	}
}