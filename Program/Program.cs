using System;

namespace Dice_Game
{
    class Program
    {
        static void Main(string[] args)
        {  
               int playerRandomNum;
               int computerNum;
               int playerpoint = 0;
               int compoint = 0;
           
               Random random = new Random();
           
               for (int i = 0; i < 10; i++)
               {
              
               Console.WriteLine("tekan apa saja untuk melempar dadu");
               Console.ReadKey();

                playerRandomNum = random.Next(1,7);
                Console.WriteLine("Angka dan dadu :" +playerRandomNum);

                computerNum = random.Next(1,7);
                Console.WriteLine("Angka dadu komputer:" +computerNum);


                if(playerRandomNum > computerNum)
                {
                 playerpoint++;
                 Console.WriteLine("anda menang di round ini");
                }
                else if(playerRandomNum < computerNum)
                {
                 compoint++;
                 Console.WriteLine("anda kalah di round ini");
                }
                else
                {
                 Console.WriteLine("anda seri");
                }
                Console.WriteLine("skor player : " + playerpoint + ". komputer : " + compoint + ".");
                }
                if(playerpoint > compoint)
                {
                 Console.WriteLine("kamu menang");
                }
                else if(playerpoint < compoint)
                {
                Console.WriteLine("kamu kalah");
                }
                Console.ReadKey();
  
        }
    }
}