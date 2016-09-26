using System;
using System.Collections.Generic;
using System.Text;

namespace IdentifikasiSudutSegitiga
{
	class JenisSudut
		{
			public static void Main(string[] args)
				{
					double a=0,b=0,c=0,hasil=0,hasil2=0,hasil3=0;
					Console.Out.WriteLine("Masukkan Panjang dari Sisi a,b, dan c dari segitiga yang ingin anda identifikasi jenis sudutnya.");
					a=Convert.ToDouble(Console.In.ReadLine());
					b=Convert.ToDouble(Console.In.ReadLine());
					c=Convert.ToDouble(Console.In.ReadLine());
					hasil=Math.Pow(a,2);
					hasil2=Math.Pow(b,2);
					hasil3=Math.Pow(c,2);
					if (hasil<=(hasil2+hasil3))
						{
							Console.Out.WriteLine("Sudut Lancip pada A.");
						}
					else if(hasil2<=(hasil+hasil3))
							{
								Console.Out.WriteLine("Sudut Lancip pada B.");
							}
						else if (hasil3<=(hasil+hasil2))
								{
									Console.Out.WriteLine("Sudut Lancip pada C.");
								}
							else
									Console.Out.WriteLine(".......................");
					if(hasil>=(hasil2+hasil3))
						{
							Console.Out.WriteLine("Sudut Tumpul pada A.");
						}
					else if(hasil2>=(hasil+hasil3))
							{
								Console.Out.WriteLine("Sudut Tumpul pada B.");
							}
						else if (hasil3>=(hasil+hasil2))
								{
									Console.Out.WriteLine("Sudut Tumpul pada C.");
								}
							else
									Console.Out.WriteLine("........................");
					if(hasil==(hasil2+hasil3))
						{
							Console.Out.WriteLine("Sudut Siku di A.");
						}
					else if (hasil2==(hasil+hasil3))
							{
								Console.Out.WriteLine("Sudut Siku di B.");
							}
						else if(hasil3==(hasil+hasil2))
								{
									Console.Out.WriteLine("Sudut Siku di C.");
								}
							else
									Console.Out.WriteLine(".................");
				}
		}
}