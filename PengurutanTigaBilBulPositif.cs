using System;
using System.Collections.Generic;
using System.Text;

namespace UrutTigaBilBulPositif
	{
	class Urutan
		{
		public static void Main(string[] args)
			{
			int bilangan=0,bilangan2=0,bilangan3=0,a=0,b=0,c=0;
			Console.Out.WriteLine("Masukkan Tiga Nilai Bilangan Bulat Positif yang Anda Inginkan.");
			bilangan=Convert.ToInt32(Console.In.ReadLine());
			bilangan2=Convert.ToInt32(Console.In.ReadLine());
			bilangan3=Convert.ToInt32(Console.In.ReadLine());
			if (bilangan>=bilangan2 && bilangan>=bilangan3)
				{
					c=bilangan;
					if (bilangan2>=bilangan3)
						{
							b=bilangan2; 
							a=bilangan3;
						}
					else
						{
							b=bilangan3;
							a=bilangan2;
						}
				}
			else
				if (bilangan2>=bilangan && bilangan2>=bilangan3)
					{
						c=bilangan2;
						if(bilangan>=bilangan3)
							{
								b=bilangan;
								a=bilangan3;
							}
						else
							{
								b=bilangan3;
								a=bilangan2;
							}
					}
				else
						if (bilangan3>=bilangan && bilangan3>=bilangan2)
							{
								c=bilangan3;
								if(bilangan>=bilangan2)
									{
										b=bilangan;
										a=bilangan2;
									}
								else
									{
										b=bilangan2;
										a=bilangan;
									}
							}
						else
							Console.Out.WriteLine("Maaf, Angka yang Anda Masukkan Salah.");
			Console.Out.WriteLine("Urutan Angka yang Anda Masukkan adalah {0} {1} {2}",a,b,c);
			Console.ReadLine();
			}
		}
	}
