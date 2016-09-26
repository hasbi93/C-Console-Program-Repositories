using System;
using System.Collections.Generic;
using System.Text;

namespace KonversiStrtoInt
{
	class Konversi
	{
		public static void Main(string[] args)
			{
				string angka="";
				uint angka2=0;
				Console.Out.WriteLine("Masukkan angka satu-sembilan(dalam huruf kecil) yang ingin dikonversi ke integer.");
				angka=Console.In.ReadLine();
				if (string.Compare(angka,"satu")==0)
					{
						angka2=1;
						Console.Out.WriteLine("{0}",angka2);
					}
				else if (string.Compare(angka,"dua")==0)
						{
							angka2=2;
							Console.Out.WriteLine("{0}",angka2);
						}
					else if (string.Compare(angka,"tiga")==0)
							{
								angka2=3;
								Console.Out.WriteLine("{0}",angka2);
							}
						else if(string.Compare(angka,"empat")==0)
								{
									angka2=4;
									Console.Out.WriteLine("{0}",angka2);
								}
							else if(string.Compare(angka,"lima")==0)
									{
										angka2=5;
										Console.Out.WriteLine("{0}",angka2);
									}
								else if(string.Compare(angka,"enam")==0)
										{
											angka2=6;
											Console.Out.WriteLine("{0}",angka2);
										}
									else if (string.Compare(angka,"tujuh")==0)
											{
												angka2=7;
												Console.Out.WriteLine("{0}",angka2);
											}
										else if (string.Compare(angka,"delapan")==0)
												{
													angka2=8;
													Console.Out.WriteLine("{0}",angka2);
												}
											else if (string.Compare(angka,"sembilan")==0)
													{
														angka2=9;
														Console.Out.WriteLine("{0}",angka2);
													}
												else
													{
														Console.Out.WriteLine("Maaf, angka yang anda masukkan salah.");
													}
												Console.In.ReadLine();
			}
	}
}