//Romi  2207111400
using System;

namespace AdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Welcome to My Adventure Game");
            Console.WriteLine("What is your Name?");
            Novice player = new Novice();
            player.Name = Console.ReadLine();
            Console.WriteLine("Hi!"+player.Name+ ",Ready to begin the game?[y/n] ");
            string bReady = Console.ReadLine();
            if (bReady =="y")
            {
               Console.WriteLine(player.Name+ " is entering the world....") ;
               Enemy enemy1 = new Enemy("Tiger");
               Console.WriteLine(player.Name+" is encountering " + enemy1.Name );
               Console.WriteLine(enemy1.Name+" attacking you.....");
               Console.WriteLine("Choose your action :");
               Console.WriteLine("1. Single Attack ");
               Console.WriteLine("2. Swing Attack ");
               Console.WriteLine("3. Defend ");
               Console.WriteLine("4. Run Away ");
               while (!player.IsDead && !enemy1.IsDead)
                {
                string playerAction = Console.ReadLine();
                switch(playerAction)
                {
                    case "1" :
                    Console.WriteLine(player.Name+"Is doing Single attack");
                    enemy1.Gethit(player.AttackPower);
                    player.Experience += 0.3f;
                    enemy1.Attack(enemy1.AttackPower);
                    player.Gethit(enemy1.AttackPower);
                    Console.Write("Player Health :"+player.Health+" | Enemy Health :"+enemy1.Health+"\n");
                    break;
                    case "2" :
                    player.Swing();
                    enemy1.Gethit(player.AttackPower);
                    player.Experience += 1.3f;
                    Console.Write("Player Health :"+player.Health+" | Enemy Health :"+enemy1.Health+"\n");
                    break;
                    case "3" :
                    player.Rest();
                    Console.WriteLine("Energy being restored");
                    enemy1.Attack(enemy1.AttackPower);
                    player.Gethit(enemy1.AttackPower);
                    break;
                    
                    case "4" :
                    Console.WriteLine(player.Name+"Is running away.....");
                    break;
                    
                    
                }
               }

                Console.WriteLine(player.Name+ "get"+player.Experience+" experience point");

            }else
            {
                Console.WriteLine("Goodbye...");
                Console.Read();
            }
            
        }
    }

    class Novice
    {
        public int Health { get; set; }
        public string  Name { get; set; }
        public int AttackPower { get; set; }
        public int SkillSlot { get; set; }
        public bool IsDead { get; set; }
        public float Experience { get; set; }
        Random rnd = new Random();

        public Novice(){
            Health = 100;
            SkillSlot = 0;
            AttackPower = 1;
            IsDead = false;
            Experience = 0f;
        }
        public void Swing(){
            if(SkillSlot > 0){
            
                Console.WriteLine("SWINGG!!!");
                AttackPower = AttackPower+ rnd.Next(3,11);
                SkillSlot--;
            }else
            {
                Console.WriteLine("You are not have energy!");
            }
        }
        
        public void Gethit(int hitvalue){
            Console.WriteLine(Name+" get hit by "+hitvalue);
            Health = Health - hitvalue;

            if (Health <= 0)
            {
                Health = 0;
                Die();
            }
        }
        public void Rest(){
            SkillSlot = 3;
            AttackPower= 1;

        }
        public void Die(){
        
        Console.WriteLine(" You are dead,Game Over ");
            IsDead = true;

        }
    }
    class Enemy
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public bool IsDead {get; set; }
        Random rnd = new Random();


        public Enemy(string name){
            Health = 50;
            Name = name;
        }
        public void Attack (int damage){
            AttackPower = rnd.Next(1,10);


        }
        public void Gethit(int hitvalue){
            Console.WriteLine(Name+" get hit by "+hitvalue);
            Health = Health - hitvalue;
            if (Health <= 0)
            {
                Health = 0;
                Die();
            }



        }
        public void Die (){
            Console.WriteLine(Name+" is dead ");
            IsDead = true;

        }
            
            

        }
    
        

}