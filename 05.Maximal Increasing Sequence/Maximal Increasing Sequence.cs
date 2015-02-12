using System;

//Write a program that finds the maximal increasing sequence in an array.

class IncreasingSequence
{
    static void Main()
    {
        Console.Write("Enter the array: ");
        int n = int.Parse(Console.ReadLine());
        int currentSeq = 1;
        int bestSeq = 1;
        string currNum = "";
        string bestNum = "";
        int[] IncreaseNum = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("IncreaseNum[{0}] = ", i);
            IncreaseNum[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n - 1; i++)
        {
            if (IncreaseNum[i] < IncreaseNum[i + 1])
            {
                currentSeq++;
                currNum += IncreaseNum[i] + " ";

            }
            else
            {
                if (currentSeq > bestSeq)
                {
                    bestSeq = currentSeq;
                    currNum += IncreaseNum[i] + " ";
                    bestNum = currNum;
                }
                currentSeq = 1;
                currNum = "";
            }
        }
        if (currentSeq > bestSeq)
        {
            currNum += IncreaseNum[IncreaseNum.Length - 1];
            bestNum = currNum;
        }

        Console.WriteLine(bestNum);
    }
}

