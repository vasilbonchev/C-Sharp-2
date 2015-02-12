using System;


//Write a program that compares two char arrays lexicographically (letter by letter).


class CharArraysCompare
{
    static void Main()
    {
        Console.Write("Enter first array: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter second array: ");
        int m = int.Parse(Console.ReadLine());
        char[] firstArray = new char[n];
        char[] secondArray = new char[m];
        bool isEqual = true;

        if (n == m)
        {
            Console.WriteLine("Enter {0} chars for the first array: ", n);

            for (int i = 0; i < n; i++)
            {
                Console.Write("Char: ", i);
                firstArray[i] = char.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter {0} chars for the second array: ", m);

            for (int i = 0; i < m; i++)
            {
                Console.Write("Char: ");
                secondArray[i] = char.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    isEqual = false;
                }
            }
        }
        else
        {
            isEqual = false;
        }

        Console.WriteLine("Equal = {0} ", isEqual);

    }
}

