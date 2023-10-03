//02 Collections, Kenneth Whitfield, v0.1b
using System;

namespace _02_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // collectons are variabler that can store multiple values in variable

            /*
            -- Number of elements in an array cannot be changed
            -- items in an array are called elements 
            --contents of elements in an array can be changed
            -- arrayes are ordered, meaning each item has a fixed location
            -- the position is known as the index
            -- the first elelment of an array is index 0
            */

            //Declaring and definig an array
            string[] breakfastFoods = {"Bacon", "Waffles", "Pancakes", "Cereal", "Parfait"};
            int[] testScores = {95, 100, 25, 15, 27, 35};
            float[] GPA = {3.14f,2.25f, 1.74f, 1.99f, 0.99f, 4.25f };

            // print array contenrs -- all elements on a single line
            Console.WriteLine("the elements for each array are:\n");
            Console.WriteLine("breakfastFoods: \n" + String.Join(", ", breakfastFoods));
            Console.WriteLine();

            Console.WriteLine("testScores: \n" + String.Join(", ", testScores));
            Console.WriteLine();

            Console.WriteLine("GPA: \n" + String.Join(", ", GPA));
            Console.WriteLine();
        }
    }
}
