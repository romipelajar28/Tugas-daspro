// Romi nim 2207111400//
using System;


namespace Tiket_Bioskop
{
    class Program
    {
        public static void Main(string[] args) {
            string Nama;
            int year;
            int  Price;
            Console.WriteLine("Nama : ");
            Nama = Console.ReadLine();
            Console.WriteLine("Tahun kelahiran : ");
            year = int.Parse(Console.ReadLine()); 
            if (2022-year < 10 || 2022-year > 60) {
                Price = 10000;
            } else {
                Price = 25000;
            }
            

            Console.WriteLine("|*******************************|");
            Console.WriteLine("{0,-8} {1,15} {2,8}", "|", "-- Studio 1 --","|"); 
            Console.WriteLine("{0,-8} {1,24}", "|Nama:", Nama+"|");
            Console.WriteLine("{0,-8} {1,4} {2,19}", "|Harga:", "Rp",Price+".00|");
            Console.WriteLine("|-------------------------------|");
        }
    }
}