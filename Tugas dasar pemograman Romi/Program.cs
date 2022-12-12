 using System;

namespace das_pro
{
    class Program
    { //Main method
        static void Main(string[] args)
        { //Deklarasi Variabel
               const int a = 5;
               const int b= 4;
               const int c =7;
                
                int tambah = a + b + c;
                int kali = a * b * c;
                int kurang = a-b-c;
                int bagi = a/b/c;
            //Menuliskan Narasi
            Console.WriteLine("Anda adalah agen rahasia yang bertugas mendapatkan data dari server");
            Console.WriteLine("Akses ke server membutuhkan pasword yang tidak diketahui ....");

            Console.WriteLine("-Jika ditambahkan hasilnya "+tambah);
            Console.WriteLine("-Jika dikalikan hasilnya "+kali);
            Console.WriteLine("-Jika dikurang hasilnya "+kurang);
            Console.WriteLine("-jika dibagi hasilnya "+bagi);
        
        }   
    }

}
