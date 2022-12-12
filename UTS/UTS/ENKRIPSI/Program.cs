// Romi nim 2207111400//
using System;
using System.Text.RegularExpressions;

namespace Enkripsi
{
    class Program
    {
           static void Main(string[] args) {
            string Teks= " ";
            string Enkripsi =" ";
            string alfabet = "abcdefghijklmnopqrstuvwxyzabcABCDEFGHIJKLMNOPQRSTUVWXYZABC";
            Regex rgx = new Regex("[^A-Za-z ]");


            do
            {
             Console.Write("Teks :"); Teks = Console.ReadLine(); 
            } while (string.IsNullOrEmpty(Teks)|| rgx.IsMatch(Teks));
                foreach (char t in Teks)
                {
                char temp = ' ';
                
                for (int i = 0; i < alfabet.Length; i++)
                {
                  char c = alfabet[i];
                  if (t.Equals(c) )
                  {
                    temp =alfabet[i+3];
                     break;}
                    else if (t.Equals(' '))
                    {
                       temp = ' ' ;
                       break;
                    }
          
                }
                  
                Enkripsi = Enkripsi + temp;
                
             }
            
            Console.WriteLine("Hasil Enkripsi:" + Enkripsi);


        }
    }
}
