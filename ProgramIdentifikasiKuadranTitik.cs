using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramIdentifikasiKuadranTitik{
	struct Titik{
		public int x,y;
	}
	struct Kuadran{
		public string I,II,III,IV;
	}
	class ProgramIdentifikasiKuadranTitik{
		public static void Main(string[] args){
			Titik t;
			Kuadran k;
			k.I="Kuadran 1";
			k.II="Kuadran 2";
			k.III="Kuadran 3";
			k.IV="Kuadran 4";
			System.Console.Out.WriteLine("Masukkan nilai x dan y secara berurutan: ");
			t.x=System.Convert.ToInt32(System.Console.In.ReadLine());
			t.y=System.Convert.ToInt32(System.Console.In.ReadLine());
			if ((t.x>=0)&&(t.y>=0)){
				System.Console.Out.WriteLine(k.I);
			} else if ((t.x<=0)&&(t.y>=0)){
				System.Console.Out.WriteLine(k.II);
			} else if ((t.x<=0)&&(t.y<=0)){
				System.Console.Out.WriteLine(k.III);
			} else {
				System.Console.Out.WriteLine(k.IV);
			}
		}
	}
}