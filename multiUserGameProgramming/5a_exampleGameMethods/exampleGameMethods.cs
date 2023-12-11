//Kenneth Whitfield, Template, v0.
using System;
using System.Collections;

namespace BasicCombatSim
{
    
    class Template
    
    {
        static string[] Inventory()//What is your inventory
        {
            string[] inventory = {"mini potion", "normal potion", "military grade potion"};
            return inventory;
        }
        static int[] Combat()//Decide damage
        {
            int gokuHealth = 100;
            int health = 50;

            Random playerRoll = new Random();
            int playerRolls = playerRoll.Next(1, 7);

            Random gokuRoll = new Random();
            int gokuRolls = gokuRoll.Next(1, 7);

            if (playerRolls > gokuRolls){
                gokuHealth -= playerRolls;
            } else if (playerRolls <= gokuRolls){
                health -= gokuRolls;
            } else{
                Console.WriteLine("ERROR");
            }
            
            int[] healthList = {health, gokuHealth};
            
            return healthList;
        }
        static int Healing()//Decides how much you can heal at onece
        {
            Console.WriteLine("You have a " + Inventory() + " In your inventory which would you like to use. To go back to combat type back");
            int healAmount = Console.ReadLine();  
           
            if (healAmount = "military grade potion") {
                health += 10;
            } else if(healAmount == "normal potion"){
                health += 5;
            } else if(healAmount == "mini potion" ){
                health += 2;
            } else if(healAmount == "back"){
                work();
            } else{
                Console.WriteLine("ERROR");
            }
                
            return health;
        }
        static void work(int gokuHealth,int health)//Decide who wins
        {

            Console.WriteLine("You are fighting Goku he has " + gokuHealth + " left, what do you want to do fight or heal\n");
            // string playerAction = Console.ReadLine("type every thing in lowercase, type heal to go to healing menu, type fight to fight\n");
            while (health > 0 | gokuHealth >0)
            {
                string playerAction = Console.ReadLine("type every thing in lowercase, type heal to go to healing menu, type fight to fight\n");
                
                if(playerAction == "fight"){
                    Combat();
                } else if(playerAction =="heal"){
                    Healing();
                } else{
                    Console.WriteLine("Error");
                }
                
            }    
        }
        static void Main(string[] args)
        {
            work();
        }
    }
}
