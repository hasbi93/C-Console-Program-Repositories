/*
* Title               : Console Program Convert Latin Numerical to Roman Numeric (ProgramConsoleConverterLatinNumericalToRomanNumeric.cs)
* Program Description : Write a C# Language Program to Convert Latin Numerical to Roman Numerical.
* Author              : Muhammad Hasbi, S.T.
* Interface           : Console
* IDE                 : Dev-C++ 5.11
* Operating System    : Windows 8 Pro
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace LatinNumericToRomanNumericConverter
{
	class LatinNumericToRomanNumericConverter
	{
		public static void Main(string[] args)
		{
			uint decimalNumber=0, j=0, m=0, d=0, c=0, l=0, x=0, ix=0, v=0, iv=0, i=0;
			System.Console.Out.WriteLine("Program Console, Latin Numeric to Roman Numeric Converter. \n");
			System.Console.Out.WriteLine("Enter The Number You Want To Convert= \n");
			decimalNumber=System.Convert.ToUInt32(System.Console.In.ReadLine());
			m=decimalNumber/1000;
			decimalNumber=decimalNumber%1000;
			d=decimalNumber/500;
			decimalNumber=decimalNumber%500;
			c=decimalNumber/100;
			decimalNumber=decimalNumber%100;
			l=decimalNumber/50;
			decimalNumber=decimalNumber%50;
			x=decimalNumber/10;
			decimalNumber=decimalNumber%10;
			ix=decimalNumber/9;
			decimalNumber=decimalNumber%9;
			v=decimalNumber/5;
			decimalNumber=decimalNumber%5;
			iv=decimalNumber/4;
			decimalNumber=decimalNumber%4;
			i=decimalNumber;
			
			System.Console.Out.WriteLine("Roman Numeral= ");
			
			for(j=1;j<=m;j++)
			{
				System.Console.Out.WriteLine("M");
			}
			for(j=1;j<=d;j++)
			{
				System.Console.Out.WriteLine("D");
			}
			for(j=1;j<=c;j++)
			{
				System.Console.Out.WriteLine("C");
			}
			for(j=1;j<=l;j++)
			{
				System.Console.Out.WriteLine("L");
			}
			for(j=1;j<=x;j++)
			{
				System.Console.Out.WriteLine("X");
			}
			for(j=1;j<=ix;j++)
			{
				System.Console.Out.WriteLine("ÏX");
			}
			for(j=1;j<=v;j++)
			{
				System.Console.Out.WriteLine("V");
			}
			for(j=1;j<=iv;j++)
			{
				System.Console.Out.WriteLine("IV");
			}
			for(j=1;j<=i;j++)
			{
				System.Console.Out.WriteLine("I");
			}
			System.Console.Out.WriteLine("\n");
			System.Console.Out.WriteLine("Press Enter To Exit Program.");
		}
		
	}
}