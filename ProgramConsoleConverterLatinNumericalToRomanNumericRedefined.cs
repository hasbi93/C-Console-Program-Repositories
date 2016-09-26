/*
* Title               : Console Program Continuous Convert Latin Numerical to Roman Numeric Redefined (ProgramConsoleConverterLatinNumericalToRomanNumericRedefined.cs)
* Program Description : Write a C# Language Program to Convert Latin Numerical to Roman Numerical Redefined.
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
			uint decimalNumber=0, j=1, m=0, d=0, c=0, l=0, x=0, ix=0, v=0, iv=0, i=0;
			System.Console.Out.WriteLine("Program Console, Latin Numeric to Roman Numeric Converter. \n");
			while(j!=0)
			{
			System.Console.Out.WriteLine("Enter The Number You Want To Convert= \n");
			decimalNumber=System.Convert.ToUInt32(System.Console.In.ReadLine());
			System.Console.Out.WriteLine("\n");
			
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
			
			System.Console.Out.Write("Roman Numeral= ");
			
			for(j=1;j<=m;j++)
			{
				System.Console.Out.Write("M");
			}
			for(j=1;j<=d;j++)
			{
				System.Console.Out.Write("D");
			}
			for(j=1;j<=c;j++)
			{
				System.Console.Out.Write("C");
			}
			for(j=1;j<=l;j++)
			{
				System.Console.Out.Write("L");
			}
			for(j=1;j<=x;j++)
			{
				System.Console.Out.Write("X");
			}
			for(j=1;j<=ix;j++)
			{
				System.Console.Out.Write("ÏX");
			}
			for(j=1;j<=v;j++)
			{
				System.Console.Out.Write("V");
			}
			for(j=1;j<=iv;j++)
			{
				System.Console.Out.Write("IV");
			}
			for(j=1;j<=i;j++)
			{
				System.Console.Out.Write("I");
			}
			System.Console.Out.WriteLine(" ");
			System.Console.Out.WriteLine("\n");
			System.Console.Out.WriteLine("Insert Any Positive Integer Number To Continue The Program: \n");
			System.Console.Out.WriteLine("Insert 0 To Stop The Program: \n");
			j=System.Convert.ToUInt32(System.Console.In.ReadLine());
			}
		}
		
	}
}