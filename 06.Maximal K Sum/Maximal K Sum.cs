using System;

//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.


class MaximalKSum
{
    static void Main()
    {
        Console.Write("First number: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Second number: ");
        int K = int.Parse(Console.ReadLine());
        int sum = 0;
        int[] arr = new int[N];

        for (int i = 0; i < N; i++)
        {
            Console.Write("Insert number of the array: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arr);
        Array.Reverse(arr);

        for (int i = 0; i < K; i++)
        {
            sum += arr[i];
        }

        Console.WriteLine("The sum of {0} is {1}. ", K, sum);
    }
}

