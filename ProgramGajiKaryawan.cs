using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramGajiKaryawan{
	struct nama{
		public string n;
	}
	struct JumlahJamKerja{
		public int JJK;
	}
	struct Gaji{
		public double lembur,upah,perjam;
	}
	class ProgramGajiKaryawan{
		public static void Main(string[] args){
			nama n;
			JumlahJamKerja j;
			Gaji g;
			g.perjam=2000;
			g.lembur=3000;
			System.Console.Out.WriteLine("Masukkan Nama dan Jumlah Jam Kerja anda secara berurutan: ");
			n.n=System.Convert.ToString(System.Console.In.ReadLine());
			j.JJK=System.Convert.ToInt32(System.Console.In.ReadLine());
			if (j.JJK<=48){
				g.upah=g.perjam*48;
				System.Console.Out.WriteLine("Saudara {0}, Gaji Anda adalah {1} Rupiah.",n.n,g.upah);
			} else {
				g.upah=(g.perjam*48)+((j.JJK-48)*g.lembur);
				System.Console.Out.WriteLine("Saudara {0}, Gaji Anda adalah {1} Rupiah.",n.n,g.upah);
			}
		}
	}
}
