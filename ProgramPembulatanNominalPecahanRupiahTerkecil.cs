using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramPembulatanNominalPecahanRupiahTerkecil{
	struct Pecahan{
		public int pec,seratus,duaratus,limaratus,seribu,duaribu,limaribu,sepuluhribu,duapuluhribu,limapuluhribu,seratusribu;
	}
	class ProgramPembulatanNominalPecahanRupiahTerkecil{
		public static void Main(string[] args){
			Pecahan P;
			P.pec=0;
			P.seratus=0;
			P.duaratus=0;
			P.limaratus=0;
			P.seribu=0;
			P.duaribu=0;
			P.limaribu=0;
			P.sepuluhribu=0;
			P.duapuluhribu=0;
			P.limapuluhribu=0;
			P.seratusribu=0;
			int input=0;
			int hasil=0,sisa=0;
			System.Console.Out.WriteLine("Masukkan Nominal Rupiah Tertentu: (dalam bentuk Integer) ");
			input=System.Convert.ToInt32(System.Console.In.ReadLine());
			P.seratusribu=input/100000;
			sisa=input%100000;
			P.limapuluhribu=sisa/50000;
			sisa=sisa%50000;
			P.duapuluhribu=sisa/20000;
			sisa=sisa%20000;
			P.sepuluhribu=sisa/10000;
			sisa=sisa%10000;
			P.limaribu=sisa/5000;
			sisa=sisa%5000;
			P.duaribu=sisa/2000;
			sisa=sisa%2000;
			P.seribu=sisa/1000;
			sisa=sisa%1000;
			P.limaratus=sisa/500;
			sisa=sisa%500;
			P.duaratus=sisa/200;
			sisa=sisa%200;
			P.seratus=sisa/100;
			P.pec=sisa%100;
			hasil=((P.seratusribu*100000)+(P.limapuluhribu*50000)+(P.duapuluhribu*20000)+(P.sepuluhribu*10000)+(P.limaribu*5000)+(P.duaribu*2000)+(P.seribu*1000)+(P.limaratus*500)+(P.duaratus*200)+(P.seratus*100));
			System.Console.Out.WriteLine("Hasil Pembulatan: {0}",hasil);
		}
	}
}