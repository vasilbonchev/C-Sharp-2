using System;


//Write a program that reads two integer arrays from the console and compares them element by element.


class ComparingArrays
{
    static void Main()
    {
        Console.Write("Enter size of the first array: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter size of the second array: ");
        int b = int.Parse(Console.ReadLine());
        int[] firstArray = new int[a];
        int[] secondArray = new int[b];
        bool isEqual = true;

        if (a == b)
        {
            Console.WriteLine("Enter {0} numbers for the first array: ", a);

            for (int i = 0; i < a; i++)
            {
                Console.Write("Number: ", i);
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter {0} numbers for the second array: ", b);

            for (int i = 0; i < b; i++)
            {
                Console.Write("Number: ", i);
                secondArray[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < a; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    isEqual = false;
                    break;
                }
            }
        }
        else
        {
            isEqual = false;
        }

        Console.WriteLine("Ëqual = {0}", isEqual);


    }
}
