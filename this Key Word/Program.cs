using System;

namespace this_Key_Word
{
    class Kostumer
    {
        int NoAkun;
        string Nama;
        double Saldo;
        string Kontak;

        public Kostumer()
        {
            Console.WriteLine("Hello World");
        }

        public Kostumer(int NoAkun, string Nama, double Saldo):this()
        {
            this.NoAkun = NoAkun;
            this.Nama = Nama;
            this.Saldo = Saldo;
        }


        public Kostumer(int NoAkun, string Nama, double Saldo, string Kontak):this(NoAkun,Nama,Saldo)
        {
            //this.NoAkun = NoAkun;
            //this.Nama = Nama;
            //this.Saldo = Saldo;
            this.Kontak = Kontak;
        }

        public void Simpan(double Jumlah)
        {
            Saldo = Saldo + Jumlah;
        }

        public void Ambil(double Jumlah)
        {
            Saldo = Saldo - Jumlah;
        }

        public void KeteranganSaldo()
        {
            Console.WriteLine("NoAkun : " + NoAkun + "  Nama : " + Nama + "  Saldo : " + Saldo + "  Kontak : " + Kontak);
        }

        public void KeteranganSaldo(double Jumlah, string p)
        {
            if (p == "Simpan")
            {
                Saldo += Jumlah;
            }
            else if (p == "Ambil")
            {
                Saldo -= Jumlah;
            }
            else
            {
                Console.WriteLine("Pilihan Salah");
            }

            Console.WriteLine("NoAkun : " + NoAkun + "  Nama : " + Nama + "  Saldo : " + Saldo + "  Kontak : " + Kontak);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Kostumer k = new Kostumer(123, "Lerados", 750000, "085712345678");

            k.KeteranganSaldo();

            Kostumer k1 = new Kostumer(124, "Galih", 600000);

            k1.KeteranganSaldo();

            Console.ReadLine();
        }
    }
}