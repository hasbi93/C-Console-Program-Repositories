/*
* Title               : Console Program Bank Credit Debit Transaction Simulation(ConsoleProgramBankCreditDebitTransactionSimulation.cs)
* Program Description : Write a C# Language Program to Simulate Bank Credit Debit Transaction and Present Them on The Screen
* Author              : Muhammad Hasbi, S.T.
* Interface           : Console
* IDE                 : Dev-C++ 5.11
* Operating System    : Windows 8 Pro
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BankCreditDebitTransactionSimulation
{
	class BankCreditDebitTransactionSimulation
	{
		public static void Main(string[] args)
		{
			int i=1,saldo=0,transaction=0,deposit=0,retrieve=0;
			System.Console.Out.WriteLine("Console Program Bank Credit Debit Transaction Simulation \n");
			System.Console.Out.WriteLine("Please Use Positive Integer Number For Input Only. \n");
			System.Console.Out.WriteLine("Enter an Amount of Money to Your Sample Account: \n");
			saldo=System.Convert.ToInt32(System.Console.In.ReadLine());
			System.Console.Out.WriteLine("Your Credit Point is {0} Rupiahs \n");
			while(i!=0)
			{
				System.Console.Out.WriteLine("Please Choose Your Type of Transaction: \n");
				System.Console.Out.WriteLine("1.Deposit an Amount of Money");
				System.Console.Out.WriteLine("2.Retrieve an Amount of Money");
				transaction=System.Convert.ToInt32(System.Console.In.ReadLine());
				switch(transaction)
				{
					case 1:
					{
						System.Console.Out.WriteLine("Deposit an Amount of Money");
						deposit=System.Convert.ToInt32(System.Console.In.ReadLine());
						saldo=saldo+deposit;
						System.Console.Out.WriteLine("Your Credit Point Is {0} Rupiahs \n",saldo);
						break;
					}
					case 2:
					{
						System.Console.Out.WriteLine("Retrieve an Amount of Money");
						retrieve=System.Convert.ToInt32(System.Console.In.ReadLine());
						saldo=saldo-retrieve;
						if(saldo<0)
						{
							saldo=saldo+retrieve;
							System.Console.Out.WriteLine("Sorry, Your Credit Point is Insufficient.");
						}
						else
						{
								System.Console.Out.WriteLine("Your Credit Point is {0} Rupiahs",saldo);
						}
						break;
					}
					default:System.Console.Out.WriteLine("Sorry, Wrong Input!!");break;
				}
			System.Console.Out.WriteLine("Enter Any Number of Positive Integer To Continue The Program: \n");
			System.Console.Out.WriteLine("Enter 0 To End The Program \n");
			i=System.Convert.ToInt32(System.Console.In.ReadLine());
			}
		}
	}
}