using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramIdentifikasiJumlahHari{
	struct Bulan{
		public int Jan,Feb,Mar,Apr,May,Jun,Jul,Aug,Sept,Oct,Nov,Dec;
	}
	class ProgramIdentifikasiJumlahHari{
		public static void Main(string[] args){
			int bulan=0,tahun=0;
			Bulan B;
			B.Jan=31;
			B.Feb=0;
			B.Mar=31;
			B.Apr=30;
			B.May=31;
			B.Jun=30;
			B.Jul=31;
			B.Aug=31;
			B.Sept=30;
			B.Oct=31;
			B.Nov=30;
			B.Dec=31;
			System.Console.Out.WriteLine("Masukkan Bulan dan Tahun Secara Berurutan untuk Mengetahui Jumlah Harinya: ");
			bulan=System.Convert.ToInt32(System.Console.In.ReadLine());
			tahun=System.Convert.ToInt32(System.Console.In.ReadLine());
			switch (bulan){
				case 1:{
					System.Console.Out.WriteLine("Jumlah Hari= {0}",B.Jan);
					break;
				}
				case 2:{
					if (((tahun%4==0)&&(tahun%100!=0))||(tahun%400==0)){
							B.Feb=29;
						} else {
							B.Feb=28;
						}
					System.Console.Out.WriteLine("Jumlah Hari= {0}",B.Feb);
					break;
				}
				case 3:{
					System.Console.Out.WriteLine("Jumlah Hari= {0}",B.Mar);
					break;
				}
				case 4:{
					System.Console.Out.WriteLine("Jumlah Hari= {0}",B.Apr);
					break;
				}
				case 5:{
					System.Console.Out.WriteLine("Jumlah Hari= {0}",B.May);
					break;
				}
				case 6:{
					System.Console.Out.WriteLine("Jumlah Hari= {0}",B.Jun);
					break;
				}
				case 7:{
					System.Console.Out.WriteLine("Jumlah Hari= {0}",B.Jul);
					break;
				}
				case 8:{
					System.Console.Out.WriteLine("Jumlah Hari= {0}",B.Aug);
					break;
				}
				case 9:{
					System.Console.Out.WriteLine("Jumlah Hari= {0}",B.Sept);
					break;
				}
				case 10:{
					System.Console.Out.WriteLine("Jumlah Hari= {0}",B.Oct);
					break;
				}
				case 11:{
					System.Console.Out.WriteLine("Jumlah Hari= {0}",B.Nov);
					break;
				}
				case 12:{
					System.Console.Out.WriteLine("Jumlah Hari= {0}",B.Dec);
					break;
				}
				default:{
					System.Console.Out.WriteLine("Maaf, Input anda Salah.");
					break;
				}
			}
		}
	}
}