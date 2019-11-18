using System;

namespace Method_Overloading
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

        public void Simpan(double Jumlah)
        {
            Saldo = Saldo + Jumlah;
        }

        public void Ambil(double Jumlah)
        {
            Saldo = Saldo - Jumlah;
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

        public void KeteranganSaldo(double Jumlah, string p)
        {
            if (p == "Simpan")
            {
                //Saldo = Saldo + Jumlah;
                Saldo += Jumlah;
            }
            else if(p == "Ambil")
            {
                Saldo -= Jumlah;
            }
            else
            {
                Console.WriteLine("Pilihan Salah");
            }

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

            k.KeteranganSaldo(20000, "Simpan");

            k.KeteranganSaldo(20000, "Ambil");

            Console.ReadLine();
        }
    }
}