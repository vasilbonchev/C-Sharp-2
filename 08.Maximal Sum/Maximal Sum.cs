using System;

//Write a program that finds the sequence of maximal sum in given array.


class MaximalSum
{
    static void Main()
    {
        int[] array = { 1, 2, -6, 4, 5, 3, -5, -8, 7, -2 };
        long maxSum = array[0];
        long currentSum = array[0];
        int curentSequenceStart = 0;
        int maxSumSequenceStart = 0;
        int maxSumSequenceLength = 1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == 0)
            {
                continue;
            }
            if ((currentSum + array[i] > currentSum) || (array[i - 1] >= array[i]))
            {
                currentSum += array[i];
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxSumSequenceStart = curentSequenceStart;
                    maxSumSequenceLength++;
                }
            }
            else
            {
                i++;
                curentSequenceStart = i;
                currentSum = array[i];
            }

        }

        int[] maxSequence = new int[maxSumSequenceLength];

        for (int i = 0; i < maxSequence.Length; i++)
        {
            maxSequence[i] = array[maxSumSequenceStart + i];
        }

        Console.WriteLine("The max sum (sum = {2}) sequence in the array [{0}] is [{1}]", String.Join(", ", array), String.Join(", ", maxSequence), maxSum);

    }
}

