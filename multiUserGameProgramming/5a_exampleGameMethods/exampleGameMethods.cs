//Kenneth Whitfield, Template, v0.
using System;

namespace BasicCombatSim
{
    class Template
    
    {
        static string Inventory()//What is your inventory
        {
            string[] inventory = {"mini potion", "normal potion", "military grade potion"};
            return inventory;
        }
        static int Combat()//Decide damage
        {
            int gokuHealth = 50;
            int health = 40;

            Random playerRoll = new Random();
            int playerRolls = playerRoll.Next(1, 7);

            Random gokuRoll = new Random();
            int gokuRolls = gokuRoll.Next(1, 7);

            if (playerRolls > gokuRolls){
                gokuHealth - playerRolls;
            } else if (playerRolls <= gokuRolls){
                health - gokuRolls;
            } else{
                Console.WriteLine("ERROR");
            }
            
        }
        static int Healing(string inventory,int health)//Decides how much you can heal at onece
        {
            healAmount = Console.ReadLine("You have a " + inventory + " In your inventory which would you like to use. To go back to combat type back")
           
            if(healAmount = "military grade potion"){
                health + 10;
            } if else(healAmount = "normal potion"){
                health + 5;
            } if else(healAmount = "mini potion" ){
                health + 2;
            } if else(healAmount = "back")
            
        }
        static void Ending()//Decide who wins
        {
            pass
        }
        static void Main(string[] args)
        {
            
        }
    }
}
