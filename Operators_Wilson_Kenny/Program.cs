using System;

namespace Operators_Wilson_Kenny
{
    class Program
    {
        static void Main(string[] args)
        {



            // Initializes an interger that multipies two intergers
            int intMult = 6 * 25;
            // Initializes an interger that adds to intergers
            int intAdd = 59 + 88;
            // Prints the maximum and mininmum of the two integer variables
            Console.WriteLine($"The max of {intMult} and {intAdd} is {Math.Max(intMult, intAdd)}. " +
                    $"The min of the two is {Math.Min(intMult, intAdd)}.");

            // Initializes boolean to see if intMult is greater than intAdd
            bool isIntGreater = intMult > intAdd;
            // Prints if intMult is greater than intAdd
            Console.WriteLine($"{intMult} is greater than {intAdd}, {isIntGreater}");

















            // Initializes an short that multipies two short
            short shortMult = 6 * 25;
            // Initializes an short that adds to short
            short shortAdd = 59 + 88;
            // Prints the maximum and mininmum of the two short variables
            Console.WriteLine($"The max of {shortMult} and {shortAdd} is .The min of the two is {Math.Max(shortMult, shortAdd)}. " +
                    $"The min of the two is {Math.Min(shortMult, shortAdd)}.");

            // Initializes boolean to see if shortMult is greater than shortAdd
            bool isshortGreater = shortMult > shortAdd;
            Console.WriteLine($"{shortMult} is greater than {shortAdd}, {isshortGreater}");


            // Initializes an long that multipies two long
            long longMult = 6 * 25;
            // Initializes anlongeger that adds to long
            long longAdd = 59 + 88;
            // Prints the maximum and mininmum of the two long variables
            Console.WriteLine($"The max of {longMult} and {longAdd} is .The min of the two is {Math.Max(longMult, longAdd)}. " +
                        $"The min of the two is {Math.Min(longMult, longAdd)}.");

            // Initializes boolean to see if longMult is greater than intAdd
            bool islongGreater = longMult > longAdd;
            // Prints if longMult is greater than longAdd
            Console.WriteLine($"{longMult} is greater than {longAdd}, {islongGreater}");






            // Initializes an integer that multipies two float
            float floatMult = 6.6f * 25.23f;
            // Initializes an float that adds to float
            float floatAdd = 59.24f + 88.91f;
            // Prints the maximum and mininmum of the two float variables
            Console.WriteLine($"The max of {floatMult} and {floatAdd} is .The min of the two is {Math.Max(floatMult, floatAdd)}. " +
                    $"The min of the two is {Math.Min(floatMult, floatAdd)}.");

            // Initializes boolean to see if floatMult is greater than floatAdd
            bool isfloatGreater = floatMult > floatAdd;
            // Prints if floatMult is greater than floatAdd
            Console.WriteLine($"{floatMult} is greater than {floatAdd}, {isfloatGreater}");

            // Initializes an double that multipies two double
            double doubleMult = 6.68 * 25.23;
            // Initializes an double that adds to double
            double doubleAdd = 59.48 + 88.91;
            // Prints the maximum and mininmum of the two double variables
            Console.WriteLine($"The max of {doubleMult} and {doubleAdd} is .The min of the two is {Math.Max(doubleMult, doubleAdd)}. " +
                        $"The min of the two is {Math.Min(doubleMult, doubleAdd)}.");

            // Initializes boolean to see if doubleMult is greater than doubleAdd
            bool isdoubleGreater = doubleMult > doubleAdd;
            Console.WriteLine($"{doubleMult} is greater than {doubleAdd}, {isdoubleGreater}");







            // Initializes an decimal that multipies two decimal
            decimal decimalMult = (decimal)(6.70 * 25.98);
            // Initializes an decimal that adds to decimal
            decimal decimalAdd = (decimal)(59.69 + 88.33);
            // Prints the maximum and mininmum of the two decimal variables
            Console.WriteLine($"The max of {decimalMult} and {decimalAdd} is .The min of the two is {Math.Max(decimalMult, decimalAdd)}. " +
                    $"The min of the two is {Math.Min(decimalMult, decimalAdd)}.");

            // Initializes boolean to see if decimalMult is greater than decimalAdd
            bool isdecimalGreater = decimalMult > decimalAdd;
            Console.WriteLine($"{decimalMult} is greater than {decimalAdd}, {isdecimalGreater}");
        }
    }
}
        