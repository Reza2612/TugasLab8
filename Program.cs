using System;
using System.Collections.Generic;
using System.Text;
using TugasLab8.ClassAnak;
using TugasLab8.ClassInduk;

namespace TugasLab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 : Inheritance,Polymorphism,Abstractions,Collection";


            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.Nama = "Artoria Pendragon";
            karyawanHarian.NIK = "170021236789";
            karyawanHarian.JumlahJamKerja = 50000;
            karyawanHarian.UpahPerJam = 10;
			
			
			KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.Nama = "Tohsaka Rin";
            karyawanTetap.NIK = "190021231124";
            karyawanTetap.GajiBulanan = 7000000;


            Sales sales = new Sales();
            sales.Nama = "Levi Ackreman";
            sales.NIK = "150028735461";
            sales.JumlahPenjualan = 50;
            sales.Komisi = 50000;

            
            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int nomorUrut = 1;

            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. Nama: {1}, NIK: {2}, Gaji: {3}", nomorUrut, karyawan.NIK, karyawan.Nama, karyawan.Gaji());

                nomorUrut++;
            }

            Console.ReadLine();
        }
    }
}