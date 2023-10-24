//Kenneth Whitfield, Template, v0.
using System;

namespace MethodsParameters
{
    class MethodsParameters
    {
        //Method -- named block of codem can be used over and over agian
        // all methods have a signature theat defines their name, parametersm and output
        //example signature
        static void  MyMethod()
        {
            Console.WriteLine("Fortnite Battlepass");
            
        }
        //static the method belongs to the current class, it is not an object   
        //void this method has no return value

        static int DoubleUp()
        {
            int sum = 0;
            Console.WriteLine("This method will double the number and return it");
            Console.WriteLine("Please enter a number on the next line");
            sum = System.Convert.ToInt32(Console.ReadLine());
            //sum*= 2;
            //Console.WriteLine(sum);
            return sum *= 2;   
        }

        //Methods with parameters
        static void MakePancakes(int num)
        {
            for(int i = 0; i< num; i++) 
            {
                //code to run
                Console.WriteLine("I scream but I do not hear");
            }
        }
        static void MakeEggs(int num, string style)
        {
            Console.WriteLine("You have ordered" + num + "eggs cooked" +style);
        }
        static void Main(string[] args)
        {
            //MyMethod();
            //DoubleUp();
           //MakePancakes();
           MakeEggs(2, "Omlet");
        }
    }
}
