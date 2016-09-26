using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramIdentifikasiNamaBulan{
	struct Bulan{
		public string Jan,Feb,Mar,Apr,May,Jun,Jul,Aug,Sept,Oct,Nov,Dec;
	}
	class ProgramIdentifikasiNamaBulan{
		public static void  Main(string[] args){
			Bulan b;
			b.Jan="January";
			b.Feb="February";
			b.Mar="March";
			b.Apr="April";
			b.May="May";
			b.Jun="June";
			b.Jul="July";
			b.Aug="August";
			b.Sept="September";
			b.Oct="October";
			b.Nov="November";
			b.Dec="December";
			int input=0;
			System.Console.Out.WriteLine("Pilih Angka Berikut Untuk Mengetahui Nama Bulan:\n1\n2\n3\n4\n5\n6\n7\n8\n9\n10\n11\n12");
			input=System.Convert.ToInt32(System.Console.In.ReadLine());
			switch (input){
				case 1:{System.Console.Out.WriteLine(b.Jan);break;}
				case 2:{System.Console.Out.WriteLine(b.Feb);break;}
				case 3:{System.Console.Out.WriteLine(b.Mar);break;}
				case 4:{System.Console.Out.WriteLine(b.Apr);break;}
				case 5:{System.Console.Out.WriteLine(b.May);break;}
				case 6:{System.Console.Out.WriteLine(b.Jun);break;}
				case 7:{System.Console.Out.WriteLine(b.Jul);break;}
				case 8:{System.Console.Out.WriteLine(b.Aug);break;}
				case 9:{System.Console.Out.WriteLine(b.Sept);break;}
				case 10:{System.Console.Out.WriteLine(b.Oct);break;}
				case 11:{System.Console.Out.WriteLine(b.Nov);break;}
				case 12:{System.Console.Out.WriteLine(b.Dec);break;}
				default:{System.Console.Out.WriteLine("Sorry, Wrong Input!");break;}
			}
		}
	}
}