using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramHitungGajiKaryawanBerdasarkanGolongan{
	struct Golongan{
		public int A,B,C,D;
	}
	struct nama{
		public string n;
	}
	struct gaji{
		public int lembur,upah,perjam;
	}
	struct JamKerja{
		public int jjk;
	}
	class ProgramHitungGajiKaryawanBerdasarkanGolongan{
		public static void Main(string[] args){
			Golongan Gol;
			nama n;
			gaji g;
			JamKerja j;
			Gol.A=0;
			Gol.B=0;
			Gol.C=0;
			Gol.D=0;
			g.perjam=0;
			int golongan=0;
			System.Console.Out.WriteLine("Masukkan Nama dan Golongan Kerja Anda(dalam Angka):\nNama:\n1.Golongan A\n2.Golongan B\n3.Golongan C\n4.Golongan D\nSecara Berurutan:");
			n.n=System.Convert.ToString(System.Console.In.ReadLine());
			golongan=System.Convert.ToInt32(System.Console.In.ReadLine());
			switch (golongan){
				case 1:{
					Gol.A=4000;
					g.perjam=Gol.A;
					break;
				}
				case 2:{
					Gol.B=5000;
					g.perjam=Gol.B;
					break;
				}
				case 3:{
					Gol.C=6000;
					g.perjam=Gol.C;
					break;
				}
				case 4:{
					Gol.D=7500;
					g.perjam=Gol.D;
					break;
				}
				default:{
					System.Console.Out.WriteLine("Maaf Input Yang Anda Masukkan Salah.\nPress Enter to Close Program.");
					break;
				}
			}
			System.Console.Out.WriteLine("Masukkan Jumlah Jam Kerja Anda: ");
			j.jjk=System.Convert.ToInt32(System.Console.In.ReadLine());
			g.lembur=3000;
			if (j.jjk<=48){
				g.upah=(j.jjk*g.perjam);
				System.Console.Out.WriteLine("Saudara {0}, gaji anda adalah {1}.",n.n,g.upah);
			} else if (j.jjk>=48){
				g.upah=(48*g.perjam)+((j.jjk-48)*g.lembur);
				System.Console.Out.WriteLine("Saudara {0}, gaji anda adalah {1}.",n.n,g.upah);
			} else {
				System.Console.Out.WriteLine("Maaf, Input yang Anda Masukkan Salah.\nPress Enter to Close Program.");
			}
		}
	}
}