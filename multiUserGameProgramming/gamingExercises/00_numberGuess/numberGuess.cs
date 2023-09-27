//Kenneth Whitfield, Number Guess, v0.0
/*
Generate secret number from a defined range(i.e. 0-1-, 0-50, 0-100)
    MATCH == first player to score three points
    Round == guessing a specific number, until correct or no more attempts
Ask the player difficulty (easy, medium, hard)
print game instructions including range and number of guesses the player has
ask the player what their guess is
determine if guess is correct or not
    if guess is correct{
        tell the player they won
        Award a point to the player
    } else {
        Tell them they're wrong
        tell player if too high or too low
        Check for remaining guesses{
            if guess remain:{
                allow player to guess again
            } else {
                CPU wins this round
            }
        }
    }
*/
using System;

namespace numberGuess
{
    class numberGuess
    {
        static void Main(string[] args)
        {
            int secretNumber = -1;
            int numGuesses = 0; // number of guesses player is allowed
            int numAttempts = 0;//Nuber of guesses taken
            int playerScore = 0;
            int cpuScore = 0;
            string difficulty = "";
            int rangeMin = -1;
            int rangeMax = -1;

            Console.WriteLine("Welcome to the number Guess Game!\n Pleas select a difficulty\nEasy: range 0 - 10 with 4 guesses\n Normal: 0-25 for 3 guesses\nHard: 0-1000000000000 with 1 guesses");
            // difficulty select
            Console.WriteLine("Please type Easy, Normal, or Hard and press ENTER");
            difficulty = Console.ReadLine(); // will save to sstring by default
            Console.WriteLine("You have selected:" = difficulty);
            if (difficulty == "Easy"){
                rangeMin = 0;
                rangeMax = 10;
                numberGuess = 4;            
            } else if (difficulty == "Normal") {
                rangeMin = 0;
                rangeMax = 25;
                numberGuess = 3;  
            } else if (difficulty == "Hard") {
                rangeMin = 0;
                rangeMax = 1000000000000;
                numberGuess = 1;  
            } else {
                Console.WriteLine("You inputed an invaled difficulty");
            }
        }
    }
}
