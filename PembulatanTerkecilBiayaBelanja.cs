using System;
using System.Collections.Generic;
using System.Text;

namespace	PembulatanTerkecilBiayaBelanja
	{	
		struct pec
			{
				public uint dualima,limapuluh,seratus,duaratus,limaratus,seribu,duaribu,limaribu,sepuluhribu,duapuluhribu,limapuluhribu,seratusribu;
			};
			
		class pembulatan
			{
				public static void Main(string[] args)
					{
						pec p;
						uint uang=0,uang2=0,pembulatan=0,sisa=0,sisa2=0,sisa3=0,sisa4=0,sisa5=0,sisa6=0,sisa7=0,sisa8=0,sisa9=0,sisa10=0,sisa11=0;
						Console.Out.WriteLine("Masukkan Total Belanja (Dalam Bentuk Bilangan Bulat Positif) Anda yang Ingin Anda Bulatkan Ke Pecahan Terkecil");
						uang=Convert.ToUInt32(Console.In.ReadLine());
						p.seratusribu=uang/100000;
						sisa=uang%100000;
						p.limapuluhribu=sisa/50000;
						sisa2=sisa%50000;
						p.duapuluhribu=sisa2/20000;
						sisa3=sisa2%20000;
						p.sepuluhribu=sisa3/10000;
						sisa4=sisa3%10000;
						p.limaribu=sisa4/5000;
						sisa5=sisa4%5000;
						p.duaribu=sisa5/2000;
						sisa6=sisa5%2000;
						p.seribu=sisa6/1000;
						sisa7=sisa6%1000;
						p.limaratus=sisa7/500;
						sisa8=sisa7%500;
						p.duaratus=sisa8/200;
						sisa9=sisa8%200;
						p.seratus=sisa9/100;
						sisa10=sisa9%100;
						p.limapuluh=sisa10/50;
						sisa11=sisa10%50;
						p.dualima=sisa11/25;
						pembulatan=sisa11%25;
						uang2=(p.seratusribu*100000)+(p.limapuluhribu*50000)+(p.duapuluhribu*20000)+(p.sepuluhribu*10000)+(p.limaribu*5000)+(p.duaribu*2000)+(p.seribu*1000)+(p.limaratus*500)+(p.duaratus*200)+(p.seratus*100)+(p.limapuluh*50)+(p.dualima*25);
						Console.Out.WriteLine("Total Harga Belanja anda setelah pembulatan ke besaran terkecil adalah Rp.{0}",uang2);						
					}
			}
	}