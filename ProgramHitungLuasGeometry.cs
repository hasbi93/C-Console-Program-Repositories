using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramHitungLuasGeometry{
	class ProgramHitungLuasGeometry{
		public static void Main(string[] args){
			int pilihan=0;
			double luas=0;
			System.Console.Out.WriteLine("Masukkan Pilihan Anda: ");
			System.Console.Out.WriteLine("1.Lingkaran");
			System.Console.Out.WriteLine("2.BujurSangkar");
			System.Console.Out.WriteLine("3.Segitiga");
			System.Console.Out.WriteLine("4.Trapesium");
			pilihan=System.Convert.ToInt32(System.Console.In.ReadLine());
			switch(pilihan){
				case 1:{
					double jariJari=0;
					System.Console.Out.WriteLine("Masukkan Jari Jari Lingkaran: ");
					jariJari=System.Convert.ToDouble(System.Console.In.ReadLine());
					luas=jariJari*jariJari*3.14;
					System.Console.Out.WriteLine("Luas Lingkaran adalah: {0} cm2",luas);
					break;
				}
				case 2:{
					double sisi=0;
					System.Console.Out.WriteLine("Masukkan Sisi dari BujurSangkar: ");
					sisi=System.Convert.ToDouble(System.Console.In.ReadLine());
					luas=sisi*sisi;
					System.Console.Out.WriteLine("Luas BujurSangkar tersebut adalah [0] cm2. ",luas);
					break;
				}
				case 3:{
					double alas=0,tinggi=0;
					System.Console.Out.WriteLine("Masukkan Alas dan Tinggi Segitiga Secara Berurutan: ");
					alas=System.Convert.ToDouble(System.Console.In.ReadLine());
					tinggi=System.Convert.ToDouble(System.Console.In.ReadLine());
					luas=0.5*alas*tinggi;
					System.Console.Out.WriteLine("Luas Segitiga Tersebut adalah {0} cm2. ",luas);
					break;
				}
				case 4:{
					double alas=0,tinggi=0;
					System.Console.Out.WriteLine("Masukkan Alas dan Tinggi Trapesium Secara Berurutan: ");
					alas=System.Convert.ToDouble(System.Console.In.ReadLine());
					tinggi=System.Convert.ToDouble(System.Console.In.ReadLine());
					luas=0.5*alas*tinggi;
					System.Console.Out.WriteLine("Luas Trapesium Tersebut adalah {0} cm2. ",luas);
					break;
				}
			}
		}
	}
}
