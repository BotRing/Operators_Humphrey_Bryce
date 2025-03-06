using System;

namespace Operators_Humphrey_Bryce
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initializes an interger that multiplies two inegers
            int intmult = 6 * 45;
            // Initializes an interger that adds two inegers
            int intadd = 55 + 66;
            // Prints the maximum and minimum and maximum of the two integer variables
            Console.WriteLine($"The max of {intmult} and {intadd} is {Math.Max(intmult, intadd)}." + 
                $"The min of the two is {Math.Min(intmult, intadd)}");
            // Initializes boolean to see if intMult is greater than intadd
            bool isIntGreater = intmult > intadd;
            // Prints is intmult is greater than intadd
            Console.WriteLine($"{intmult} is greater than {intadd}, {isIntGreater}.");

            // Initializes an short that multiplies two inegers
            short shortmult = 6 * 45;
            // Initializes an short that adds two inegers
            short shortadd = 55 + 66;
            // Prints the maximum and minimum and maximum of the two short variables
            Console.WriteLine($"The max of {shortmult} and {shortadd} is {Math.Max(shortmult, shortadd)}." +
                $"The min of the two is {Math.Min(shortmult, shortadd)}");
            // Initializes boolean to see if shortMult is greater than shortadd
            bool isshortGreater = shortmult > shortadd;
            // Prints is shortmult is greater than shortadd
            Console.WriteLine($"{shortmult} is greater than {shortadd}, {isshortGreater}.");

            // Initializes an long that multiplies two inegers
            long longmult = 6 * 45;
            // Initializes an long that adds two inegers
            long longadd = 55 + 66;
            // Prints the maximum and minimum and maximum of the two long variables
            Console.WriteLine($"The max of {longmult} and {longadd} is {Math.Max(longmult, longadd)}." +
                $"The min of the two is {Math.Min(longmult, longadd)}");
            // Initializes boolean to see if longMult is greater than longadd
            bool islongGreater = longmult > longadd;
            // Prints is longmult is greater than longadd
            Console.WriteLine($"{longmult} is greater than {longadd}, {islongGreater}.");

            // Initializes an float that multiplies two inegers
            float floatmult = 6.5f * 45.25f;
            // Initializes an float that adds two inegers
            float floatadd = 55.75f + 66.5f;
            // Prints the maximum and minimum and maximum of the two float variables
            Console.WriteLine($"The max of {floatmult} and {floatadd} is {Math.Max(floatmult, floatadd)}." +
                $"The min of the two is {Math.Min(floatmult, floatadd)}");
            // Initializes boolean to see if floatMult is greater than floatadd
            bool isfloatGreater = floatmult > floatadd;
            // Prints is floatmult is greater than floatadd
            Console.WriteLine($"{floatmult} is greater than {floatadd}, {isfloatGreater}.");

            // Initializes an double that multiplies two inegers
            double doublemult = 6.5 * 45.75;
            // Initializes an double that adds two inegers
            double doubleadd = 55.25 + 66.5;
            // Prints the maximum and minimum and maximum of the two double variables
            Console.WriteLine($"The max of {doublemult} and {doubleadd} is {Math.Max(doublemult, doubleadd)}." +
                $"The min of the two is {Math.Min(doublemult, doubleadd)}");
            // Initializes boolean to see if doubleMult is greater than doubleadd
            bool isdoubleGreater = doublemult > doubleadd;
            // Prints is doublemult is greater than doubleadd
            Console.WriteLine($"{doublemult} is greater than {doubleadd}, {isdoubleGreater}.");

            // Initializes an decimal that multiplies two inegers
            decimal decimalmult = (decimal)(6.25 * 45.15);
            // Initializes an decimal that adds two inegers
            decimal decimaladd = (decimal)(55.55 + 66.66);
            // Prints the maximum and minimum and maximum of the two decimal variables
            Console.WriteLine($"The max of {decimalmult} and {decimaladd} is {Math.Max(decimalmult, decimaladd)}." +
                $"The min of the two is {Math.Min(decimalmult, decimaladd)}");
            // Initializes boolean to see if decimalMult is greater than decimaladd
            bool isdecimalGreater = decimalmult > decimaladd;
            // Prints is decimalmult is greater than decimaladd
            Console.WriteLine($"{decimalmult} is greater than {decimaladd}, {isdecimalGreater}.");
        }
    }
}
