using System;
using System.Collections.Generic;
using System.Text;

namespace WhileJumlahRerataModTakHinggaDariPapanKetik
	{
		class WhileJumlahRerataModTakHinggaDariPapanKetik
			{
				public static void Main(string[]  args)
					{
						uint i=1,j=0, m=0,r=0,x=0;
						System.Console.Out.WriteLine("Program Penghitung Jumlah, Rerata, dan Mod Angka dari Papan Ketik \n");
						System.Console.Out.WriteLine("Masukkan Angka Pertama: \n");
						x=System.Convert.ToUInt32(System.Console.In.ReadLine());
						if (x!=0)
							{
								while (x!=0)
									{
										i=i+1;
										j=j+x;
										System.Console.Out.WriteLine("Jumlah Sementara = {0}, Angka yang Dimasukkan= {1} \n",j,x);
										System.Console.Out.WriteLine("Masukkan Angka 0 untuk Mengakhiri Program. \n");
										System.Console.Out.WriteLine("Masukkan Angka yang Ingin Anda Jumlahkan: \n");
										x=System.Convert.ToUInt32(System.Console.In.ReadLine());
											if (x==0)
												{
													i=i-1;
													r=j/i;
													m=j%i;
													System.Console.Out.WriteLine("Deret Bilangan Akhir= {0} \n",i);
													System.Console.Out.WriteLine("Rerata (j/i) = {0} \n",r);
													System.Console.Out.WriteLine("Modulus (j Mod i) = {0} \n",m);
												}
											else
												{
													System.Console.Out.WriteLine("Deret Bilangan Sementara = {0} \n",i);
												}
									}
							}
						else
							{
								System.Console.Out.WriteLine("Tidak Ada Data yang Dimasukkan. \n");
							}
					}
			}
	}