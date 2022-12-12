//Romi nim 2207111400//
using System; 

namespace Name_Tag
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nama;
            string konsen;

            Console.WriteLine("Nama  :");  Nama = Console.ReadLine();
            Console.WriteLine("NIM : "); int NIM = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Konsentrasi : "); konsen = Console.ReadLine();

            Console.WriteLine("|***************************|");
            Console.WriteLine("|NAMA : {0,20}|", Nama);
            Console.WriteLine("|{0,27}|", NIM);
            Console.WriteLine("|---------------------------|");
            Console.WriteLine("| {0,26}|", konsen);
            Console.WriteLine("|***************************|");
        }
    }
}
