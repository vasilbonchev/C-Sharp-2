using System;


//Write a program that finds the maximal sequence of equal elements in an array.


class MaximalSequence
{
    static void Main()
    {
        Console.Write("Enter the array: ");
        int input = int.Parse(Console.ReadLine());
        int[] sequenceMax = new int[input];
        int equalNum = 0;
        int currentSeq = 1;
        int bestSeq = 1;

        for (int i = 0; i < input; i++)
        {
            Console.Write("sequenceMax[{0}] = ", i);
            sequenceMax[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < input - 1; i++)
        {
            if (sequenceMax[i] == sequenceMax[i + 1])
            {
                currentSeq++;
            }
            else
            {
                currentSeq = 1;
            }
            if (currentSeq >= bestSeq)
            {
                bestSeq = currentSeq;
                equalNum = sequenceMax[i];
            }
        }
        for (int i = 0; i < bestSeq; i++)
        {
            Console.Write("{0}", equalNum);
        }

        Console.WriteLine();

    }
}

