using System;

namespace Class__Object__Access_Specifiers_dan_Constructors
{
    class Kostumer
    {
        int NoAkun;
        string Nama;
        double Saldo;

        public Kostumer()
        {
            Console.WriteLine("Hello World");
        }

        public Kostumer(int a, string n, double b)
        {
            NoAkun = a;
            Nama = n;
            Saldo = b;
        }

        public void Simpan(double jumlah)
        {
            Saldo = Saldo + jumlah;
        }

        public void Ambil(double jumlah)
        {
            Saldo = Saldo - jumlah;
        }

        //public void BuatKostumer(int a, string n, double b)
        //{
        //    NoAkun = a;
        //    Nama = n;
        //    Saldo = b;
        //}

        public void KeteranganSaldo()
        {
            Console.WriteLine("NoAkun : " + NoAkun + "  Nama : " + Nama + "  Saldo : " + Saldo);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kostumer k = new Kostumer(1234, "Galih", 800000);

            //k.BuatKostumer(123, "Lerados", 800000);

            k.KeteranganSaldo();

            k.Simpan(50000);

            k.KeteranganSaldo();

            k.Ambil(250000);

            k.KeteranganSaldo();

            Console.ReadLine();
        }
    }
}
