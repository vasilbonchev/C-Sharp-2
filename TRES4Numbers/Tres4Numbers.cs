using System;
using System.Text;
using System.Numerics;

class Tress4Numbers
{
    static void Main()
    {
        var numeralSystem = 9;
        var digits = new[] { "LON+", "VK-", "*ACAD", "^MIM", "ERIK|", "SEY&", "EMY>>", "/TEL", "<<DON" };
        BigInteger numberInDecimal = BigInteger.Parse(Console.ReadLine());

        StringBuilder result = new StringBuilder();

        if (numberInDecimal == 0)
        {
            Console.WriteLine(digits[0]);
        }

        while (numberInDecimal > 0)
        {
            int digitIn9Th = (int)(numberInDecimal % (ulong)numeralSystem);
            result.Insert(0, digits[digitIn9Th]);
            numberInDecimal /= (ulong)numeralSystem;
        }

        Console.WriteLine(result.ToString());

    }
}

