using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramSimpeCalculator{
	class ProgramSimpeCalculator{
		public static void Main(string[] args){
			int input1=0, input2=0, hasil=0;
			char oprt;
			System.Console.Out.WriteLine("Program Kalkulator Sederhana \nMasukkan Angka yang Ingin Anda Tambahkan Secara Berurutan beserta Operator \n(Angka 1) ('+','-','/','*','%') (Angka 2): ");
			input1=System.Convert.ToInt32(System.Console.In.ReadLine());
			oprt=System.Convert.ToChar(System.Console.In.ReadLine());
			input2=System.Convert.ToInt32(System.Console.In.ReadLine());
			switch (oprt){
				case '+':{
					hasil=input1+input2;
					break;
				}
				case '-':{
					hasil=input1-input2;
					break;
				}
				case '/':{
					if (input2!=0){
						hasil=input1/input2;
					} else {
						System.Console.Out.WriteLine("Error!");
					}
					break;
				}
				case '*':{
					hasil=input1*input2;
					break;
				}
				case '%':{
					hasil=input1%input2;
					break;
				}
			}
		System.Console.Out.WriteLine("Hasil = {0}",hasil);
		}
	}
}