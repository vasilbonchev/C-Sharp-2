using System;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;

// 1 zad. StrangeLand Numbers

class Numbers
{
    //Convertirane v 10 broina sistema
    static BigInteger Power(BigInteger number, BigInteger power)
    {
        BigInteger result = 1;

        for (BigInteger i = 0; i < power; i++)
        {
            result *= number;
        }

        return result;
    }
    static void Main()
    {
        //Replace na bukvite i cifrite
        string strangeNumber = Console.ReadLine()
            .Replace("f", "0")
            .Replace("bIN", "1")
            .Replace("oBJEC", "2")
            .Replace("mNTRAVL", "3")
            .Replace("lPVKNQ", "4")
            .Replace("pNWE", "5")
            .Replace("hT", "6");

        BigInteger power = 0;

        BigInteger result = 0;

        for (int i = strangeNumber.Length - 1; i >= 0; i--)
        {
            BigInteger currentNumber = strangeNumber[i] - '0';

            result += currentNumber * Power(7, power);

            power++;
        }

        Console.WriteLine(result);

        // 2 zad. Two Girls One Path
        BigInteger[] numbers = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();

        int mollyIndex = 0;
        int dollyIndex = numbers.Length - 1;

        BigInteger mollyTotalFlowers = 0;
        BigInteger dollyTotalFlowers = 0;

        string winner = string.Empty;

        while (true)
        {
            if (numbers[mollyIndex] == 0 || numbers[dollyIndex] == 0)
            {
                if (numbers[mollyIndex] == 0)
                {
                    winner = "Dolly";
                }
                else if (numbers[dollyIndex] == 0)
                {
                    winner = "Molly";
                }
                else
                {
                    winner = "Draw";
                }

                mollyTotalFlowers += numbers[mollyIndex];
                dollyTotalFlowers += numbers[dollyIndex];
                break;
            }

            BigInteger currentMollyFlowers = numbers[mollyIndex];
            BigInteger currentDollyFlowers = numbers[dollyIndex];

            numbers[mollyIndex] = 0;
            numbers[dollyIndex] = 0;

            mollyTotalFlowers += currentMollyFlowers;
            dollyTotalFlowers += currentDollyFlowers;

            mollyIndex = (int)((mollyIndex + currentMollyFlowers) % numbers.Length);
            dollyIndex = (int)((dollyIndex - currentDollyFlowers) % numbers.Length);

            if (dollyIndex < 0)
            {
                dollyIndex += numbers.Length;
            }

            Console.WriteLine(winner);
            Console.WriteLine("{0} {1}", mollyTotalFlowers, dollyTotalFlowers);

        }

        // 3 zad. Digits - s matrici

        int n = int.Parse(Console.ReadLine());

        var patterns = InitializeListOfPaterns();

        int[,] digits = new int[n, n];

        for (int row = 0; row < n; row++)
        {
            string[] currentLine = Console.ReadLine().Split(' ');

            for (int col = 0; col < currentLine.Length; col++)
            {
                digits[row, col] = int.Parse(currentLine[col]);
            }
        }

        int sum = 0;

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {

            }
        }
    }

    static int[,] digits;

    static List<bool[]> InitializeListOfPaterns()
    {
        var list = new List<bool[]>();

        list.Add(new bool[]
            {
                //fake bool
            });

        list.Add(new bool[]
             {
                 false, false, true,
                 false, true, true,
                 true, false, true,
                 false, false, true,
                 false, false, true
             });

        return list;
    }

    static bool CheckPatern(bool[,] pattern, int digit, int row, int col)
    {
        for (int i = 0; i < pattern.GetLength(0); i++)
        {
            for (int j = 0; j < pattern.GetLength(1); j++)
            {
                if (pattern[i, j])
                {
                    if (digits[row + i, col + j] != digit)
                    {
                        return false;
                    }
                }
            }
        }

        return true;
    }

    // 4 zad. Relevance Index

    static string[] symbols = new string[] { " ", ",", ".", "(", ")", ";", "-", "!", "?" };
    static void Main()
    {
        string searchWord = Console.ReadLine();
        int numberOfParagraphs = int.Parse(Console.ReadLine());

        List<string> paragraphs = new List<string>();
        List<int> indexes = new List<int>();

        for (int i = 0; i < numberOfParagraphs; i++)
        {
            var currentLineWords = Console.ReadLine().Split(symbols, StringSplitOptions.RemoveEmptyEntries);

            int relevanceIndex = 0;

            for (int j = 0; j < currentLineWords.Length; j++)
            {
                string word = currentLineWords[j];

                if (word.ToLower() == searchWord.ToLower())
                {
                    relevanceIndex++;
                    currentLineWords[j] = word.ToUpper();
                }
            }

            paragraphs.Add(String.Join(" ", currentLineWords));
            indexes.Add(relevanceIndex);
        }

        List<string> sortedParagraphs = new List<string>();

        while (sortedParagraphs.Count < paragraphs.Count)
        {
            int maxIndex = 0;
            int maxParagraphIndex = 0;

            for (int i = 0; i < indexes.Count; i++)
            {
                if (maxIndex < indexes[i])
                {
                    maxIndex = indexes[i];
                    maxParagraphIndex = i;
                }
            }

            sortedParagraphs.Add(paragraphs[maxParagraphIndex]);
            indexes[maxParagraphIndex] = -1;
        }

        Console.WriteLine(string.Join(Environment.NewLine, sortedParagraphs));

        // 5 zad. Doge Coins
        int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int rows = dimensions[0];
        int cols = dimensions[1];

        int[,] coins = new int[rows, cols];

        int k = int.Parse(Console.ReadLine());

        for (int i = 0; i < k; i++)
        {
            string[] currentCoords = Console.ReadLine().Split(' ');

            int currentCoinRow = int.Parse(currentCoords[0]);
            int currentCoinCol = int.Parse(currentCoords[1]);

            coins[currentCoinRow, currentCoinCol]++;
        }

        int[,] dp = new int[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                int maxAbove = 0;
                int maxLeft = 0;

                if (row - 1 >= 0)
                {
                    maxAbove = dp[row - 1, col];
                }

                if (col - 1 >= 0)
                {
                    maxLeft = dp[row, col - 1];
                }

                dp[row, col] = Math.Max(maxAbove, maxLeft) + coins[row, col];
            }
        }

        Console.WriteLine(dp[rows - 1, cols - 1]);
    }

}