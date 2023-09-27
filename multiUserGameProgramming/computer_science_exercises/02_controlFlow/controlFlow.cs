//Kenneth Whitfield, Control Flow, v0.5
using System;

namespace controlFlow
{
    class controlFlow
    {
        static void Main(string[] args)
        {/*
            //declerations
            string favColor = "Purple";
            int luckNumber = 19;
            float myGPA = 0.05F;
            int myAge = 17;
            bool pineappleOnPizza = false;
            
            //if statement -- check for a single condition
            if (favColor == "Green") {
                Console.WriteLine("Green with envy!");
            }

            if (myGPA >= 2.0F) {
                Console.WriteLine("You pass.");
            }

            // if - else statement checks for single condition but has two actions
            if (myAge > 15) {
                Console.WriteLine("you are eligible to drive");
            } else {
                Console.WriteLine("you are not eligible to drive");
            }

            //if - else if- else check for multiple outcomes
            if(myGpa == 4.0F) {
                Console.WriteLine("Congrats on making staight A's!");
            } else if (myGpa >= 3.0F) {
                Console.WriteLine("Congrats on making honor roll");
            } else if (myGPA >= 2.0F) {
                Console.WriteLine("Congrats on passing");
            } else {
                Console.WriteLine("YOu should probaly study");
            }
            //WHEN CHECKING NUMBER VALUES START WITH THE HIGHEST NUMBER

            //Nested Statments
            if( pineappleOnPizza == true) {
                Console.WriteLine("ew");
                if (myAge > 60){
                    Console.WriteLine("yup your old");
                } else {
                    Console.WriteLine("ok you just have bad food taste");
                }
            }else {
                Console.WriteLine("Glad to see yo uhave common sense");
            }
            
            //for loop best for when you know nmber of iterations
            
                for (statement1; statement2; statement3) {
                code to loop
            }
            //statement1 is executed Once before the loop starts.
            //statement2 is a conditional that us checked everytime before loop starts.
            //statement executes everytime after the loop executes.
            

            for(int i = 0; i < 101; i++) {
                Console.WriteLine("" + i);
            }
            for(int i = 100; i < -1; i--) {
                Console.WriteLine("" + i);
            }
            
            //nested loops
            
            for(int i = 1; i <= 2; i++) { //outer loop
                Console.WriteLine("outer: " + i);

                for(int j = 1; j <= 3; j++ ) {//inner loop
                    Console.WriteLine("Inner:  " + j);
                }

            } 
        
            // whi;e loop- best when number of iterations are unknown
            int x = 0;
            while (x < 1000) {
                Console.WriteLine("" + x);
                x++;
            }
            int y = 1000;
            while (y > 0){
                Console.WriteLine("" + y);
                x--;

            }
            //special keywords
            //break will immediatly exit a loop or an if/else if/els block
            for(int i = 0; i < 101; i++) {
                Console.WriteLine("" + i);
                if (i==50){
                    break;
                }
            }*/


            for(int i = 0; i < 101; i++) {
                Console.WriteLine("" + i);
                if (i==50){
                    continue;
                }
            }

        }
    }
}
