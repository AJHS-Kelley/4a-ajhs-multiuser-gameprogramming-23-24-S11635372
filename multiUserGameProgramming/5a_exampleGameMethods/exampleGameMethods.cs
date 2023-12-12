//Kenneth Whitfield, Template, v0.
using System;
using System.Collections;

namespace BasicCombatSim
{
    static class Globals
    {
        public static int health = 65;
        public static int gokuHealth = 100;
        public static ArrayList inventory = new ArrayList()
        {
            "mini potion", "normal potion", "military grade potion"
        };
    }
    
    class Template
    
    {
        static string Inventory()//What is your inventory
        {
            string inv = "";
            foreach (string item in Globals.inventory)
            {
                inv = inv + ", " + System.Convert.ToString(item);
            }
            
            return inv;
        }
        
        static int[] Combat()//Decide damage
        {

            Random playerRoll = new Random();
            int playerRolls = playerRoll.Next(1, 7);

            Random gokuRoll = new Random();
            int gokuRolls = gokuRoll.Next(1, 7);

            if (playerRolls > gokuRolls){
                Console.WriteLine("You rolled a " + playerRolls + ", Goku rolled a " + gokuRolls + ". You win this round.");
                Globals.gokuHealth -= playerRolls;
            } else if (playerRolls <= gokuRolls){
                Console.WriteLine("You rolled a " + playerRolls + ", Goku rolled a " + gokuRolls + ". You lost this round.");
                Globals.health -= gokuRolls;
            } else{
                Console.WriteLine("ERROR");
            }
            
            int[] healthList = {Globals.health, Globals.gokuHealth};
            
            return healthList;
        }
        static int Healing()//Decides how much you can heal at onece
        {
            Console.WriteLine("You have a " + Inventory() + ". In your inventory which would you like to use. To go back to combat type back");
            string healAmount = Console.ReadLine();  
           
            if (healAmount == "military grade potion") {
                Globals.health += 15;
                Globals.inventory.Remove("military grade potion");
            } else if(healAmount == "normal potion"){
                Globals.health += 7;
                Globals.inventory.Remove("normal potion");
            } else if(healAmount == "mini potion" ){
                Globals.health += 5;
                Globals.inventory.Remove("mini potion");
            } else if(healAmount == "back"){
                work();
            } else{
                Console.WriteLine("ERROR");
            }
                
            return Globals.health;
        }
        static void work()//Decide who wins
        {

            
            // string playerAction = Console.ReadLine("type every thing in lowercase, type heal to go to healing menu, type fight to fight\n");
            while (Globals.health > 0 && Globals.gokuHealth >0)
            {
                Console.WriteLine("You are fighting Goku, he has " + Globals.gokuHealth + " health left. You have " + Globals.health + " health left. What do you want to do, fight or heal?\n");
                Console.WriteLine("type every thing in lowercase, type heal to go to healing menu, type fight to fight\n");
                string playerAction = Console.ReadLine();
                
                if(playerAction == "fight"){
                    Combat();
                } else if(playerAction =="heal"){
                    Healing();
                } else{
                    Console.WriteLine("Error");
                }
                
            }
            
            if (Globals.health <= 0){
                Console.WriteLine("You have died get better");
            } else if(Globals.gokuHealth <= 0){
                Console.WriteLine("You won good job");
            } else{
                Console.WriteLine("Game broke go home");
            }
            
        }
        static void Main(string[] args)
        {
            work();
            //:D
        }
    }
}
