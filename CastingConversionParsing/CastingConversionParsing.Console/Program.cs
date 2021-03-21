using System;
using System.Globalization;
using static System.Console;

namespace CastingConversionParsing.Console
{
    internal class Program
    {
        private static void Main()
        {
            WriteLine("--- Casting ---");
            CastingExample();
            WriteLine("--- Conversion ---");
            ConversionExample();
            WriteLine("--- Parsing ---");
            ParsingExample();
        }
        private static void CastingExample()
        {
            const int anInteger = 5;
            const decimal aDecimal = anInteger;
            WriteLine($"Implicitly casting an integer to a decimal: {aDecimal}");

            // const decimal anotherDecimal = 123456;
            // const int anotherInteger = anotherDecimal;
            // WriteLine($"Narrowing variables by implicit casting is not supported! {anotherInteger}");

            const decimal someDecimal = 123456;
            const int someInteger = (int)someDecimal;
            WriteLine($"Narrowing variables by explicit casting is supported! {someInteger}");
            WriteLine();
        }

        private static void ConversionExample()
        {
            const double numberWithDecimals = 3.75;
            WriteLine($"Given a number with decimals: {numberWithDecimals}");
            const int truncatedNumber = (int)numberWithDecimals;
            WriteLine($"Explicit casting truncates the value and results in an unexpected rounding behaviour: {truncatedNumber}");
            int convertedNumber = Convert.ToInt32(numberWithDecimals);
            WriteLine($"Using conversion results in rounding behaviour as expected: {convertedNumber}");

            string textRepresentation = numberWithDecimals.ToString(CultureInfo.InvariantCulture);
            WriteLine("Converting a number to a text representation using the ToString() method: " + textRepresentation);
            WriteLine();
        }

        private static void ParsingExample()
        {
            int sum = 0;
            const string firstRoll = "12";
            if (int.TryParse(firstRoll, out int rollValue))
            {
                sum += rollValue;
            }

            WriteLine($"Parsing the roll and adding its value to the sum results in a sum of: {sum}");

            const string secondRoll = "INVALID";
            if (int.TryParse(secondRoll, out int rollValue2))
            {
                sum += rollValue2;
            }
            else
            {
                WriteLine($"Failed to parse roll! Sum remains at: {sum}");
            }
        }
    }
}
