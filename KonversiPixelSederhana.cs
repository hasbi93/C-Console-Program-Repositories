using System;
using System.Collections.Generic;
using System.Text;

namespace KonversiPixel
	{
		class Konversi
			{
				public static void Main(string[] args)
					{
						uint pixel=0;
						Console.Out.WriteLine("Masukkan Nilai Pixel: ");
						pixel=Convert.ToUInt32(Console.In.ReadLine());
						if (pixel<=0)
							{
								pixel=0;
							}
						else if (pixel>=255)
								{
									pixel=255;
								}
							else if (pixel<255&&pixel>0)
									{
										pixel=pixel;
									}
								else
										{
											Console.Out.WriteLine("Error!");
										}
						Console.Out.WriteLine("Nilai Pixel: {0}",pixel);
					}
			}
	}