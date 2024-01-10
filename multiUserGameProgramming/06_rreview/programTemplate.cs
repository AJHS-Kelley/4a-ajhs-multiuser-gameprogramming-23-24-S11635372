//Kenneth Whitfield, Template, v0.
using System;

namespace ReviewProject
{
    class ReviewProject
    {
        static void Main(string[] args)
        {
            /*
            // decalaring and assigning variables
            //interger -- -2,147,483,648 to 2,147,483,647
            // Interger 4 bytes
            int persona = 5;
            //Long-- -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            //Long 8 bytes
            long myLong = 2;;
            //float -- stores 6-7 decimal digits
            // Float 4 bytes
            float two = 1.999999F;
            //Double stores up to  15 decimal digits
            //double myDouble = 8.2983423809
            //Boolean -- true/false
            // boolean = 1 bit
            bool happy = false;
            //string
            //2-bytes per charecter
            //must be in  " "
            string personaFiveRoyal = "I litteraly look Joker Persona 5";
            //charecter (char)
            //Single charecter, in Single quotes ' '
            //2-bytes
            char myChar = 'M';

            //Type casting -- changing one data type to another 
            //Implicit -- happens automaticlly whn going smaller -> larger
            //char > int > long >float> double

            int myInt = 9;
            double myDouble = myInt;
            Console.WriteLine(myDouble);

            //Explecit -- must be done manuallt whn going larger to smaller
            // double > Float > long > int >char
            double example Double = 9.98320948209D;
            int myInt = (int) myDouble;

            //conversion method
            Convert.ToString() // string
            Convert.ToDouble() // Double
            Convert.ToInt32()// interger
            Convert.ToInt64()// long
*/
        //switch statment
        int dayOfWeek = 4;
        switch (dayOfWeek)
        {
            case 1:
                Console.WriteLine("The day is Sunday.\n");
                break;
            case 2:
                Console.WriteLine("The day is MOnday.\n");
                break;
            case 3:
                Console.WriteLine("The day is Tuesday.\n");
                break;
            case 4:
                Console.WriteLine("The day is Wednesday.\n");
                break;
            case 5:
                Console.WriteLine("The day is Thursday.\n");
                break;
            case 6:
                Console.WriteLine("The day is Friday.\n");
                break;
            case 7:
                Console.WriteLine("The day is Saturday.\n");
                break;
            default:
                Console.WriteLine("No MAtch Found.\n");
                break;
        }
        }
    }
}
