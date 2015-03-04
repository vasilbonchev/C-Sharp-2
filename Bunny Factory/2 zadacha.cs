using System;
using System.Numerics;
using System.Collections.Generic;

class BunnyFactory
{
    static List<int> Input()
    {
        List<int> cages = new List<int>();

        while (true)
        {
            var line = Console.ReadLine();

            if (line == "END")
            {
                break;
            }

            var cage = int.Parse(line);
            cages.Add(cage);
        }

        return cages;
    }

    static void Main()
    {
        var cages = Input();

        for (int stepNumber = 1; ; stepNumber++)
        {
            if (cages.Count < stepNumber)
            {
                break;
            }

            var cagesCount = (int)SumListValuesInRange(cages, 0, stepNumber - 1);

            if (cages.Count < stepNumber + cagesCount)
            {
                break;
            }

            var sum = SumListValuesInRange(cages, stepNumber, cagesCount + stepNumber - 1);
            var product = ProductListValuesInRange(cages, stepNumber, cagesCount + stepNumber - 1);

            string result = sum.ToString() + product.ToString();
        }
    }

    static BigInteger SumListValuesInRange(List<int> list, int startIndex, int endIndex)
    {
        BigInteger sum = 0;

        for (int i = startIndex; i <= endIndex; i++)
        {
            sum += list[i];
        }

        return sum;
    }

    static BigInteger ProductListValuesInRange(List<int> list, int start, int end)
    {
        BigInteger product = 1;

        for (int i = start; i <= end; i++)
        {
            product *= list[i];
        }

        return product;
    }
}

