//Kenneth Whitfield, Operators, v0.3
using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "string one";
            string string2 = "string two";
            int fortnightsCounted = 4;
            int persona = 3;
            int minecraftsCounted = 14;
            float bodiesFound = 13.5F;
            float nebraskanPopulation = 18.2F;

            Console.WriteLine(fortnightsCounted + minecraftsCounted);
            Console.WriteLine(string1 + string2);
            Console.WriteLine(bodiesFound + nebraskanPopulation);
            Console.WriteLine(fortnightsCounted + nebraskanPopulation);

            Console.WriteLine(fortnightsCounted + minecraftsCounted);
            //Console.WriteLine(string1 - string2);
            Console.WriteLine(bodiesFound - nebraskanPopulation);
            Console.WriteLine(fortnightsCounted - nebraskanPopulation);

            Console.WriteLine(fortnightsCounted * minecraftsCounted);
            //Console.WriteLine(string1 * string2);
            Console.WriteLine(bodiesFound * nebraskanPopulation);
            Console.WriteLine(fortnightsCounted * nebraskanPopulation);

            Console.WriteLine(fortnightsCounted / minecraftsCounted);
            //Console.WriteLine(string1 / string2);
            Console.WriteLine(bodiesFound / nebraskanPopulation);
            Console.WriteLine(fortnightsCounted / nebraskanPopulation);

            //modulus
            Console.WriteLine("Modulus");
            Console.WriteLine(16 % 5);
            Console.WriteLine(10 % 2);

            //Increment
            int robloxCounted = 1;
            robloxCounted++;
            Console.WriteLine(robloxCounted);

            int fnafCounted = 42;
            fnafCounted--;
            Console.WriteLine(fnafCounted);

            //assignment operators

            persona = 5; //If alredy has a value gets rid of it
            //these opperators keep the old values
            fortnightsCounted += 4;
            minecraftsCounted -= 2;
            bodiesFound *= 90;
            nebraskanPopulation /= 2;

            //comparisson operators

            Console.WriteLine(5 == 0);
            Console.WriteLine(6 > 4);
            Console.WriteLine(65 >= 8567458765);
            Console.WriteLine(6578976 <  8097);
            Console.WriteLine(5768859 <= 87698);
            Console.WriteLine(7986789 != 97860897678096098);

            //logical operators
            //and
            Console.WriteLine(3 > 2 && 2 == 2);
            Console.WriteLine(3 > 2 && 5 > 6 );
            //or
            Console.WriteLine(5 < 9 || 5!= 4);
            Console.WriteLine(9 < 10 || 3 > 5);
            //not -- find oppisite value
            Console.WriteLine(!(5 > 4));

        }
    }
}
