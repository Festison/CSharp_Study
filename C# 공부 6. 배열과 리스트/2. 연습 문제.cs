using System;

namespace CSahrp_공부
{
    class Program
    {
        static int GetHighestScore(int[] scores)
        {
            int maxValue = 0;

            foreach (int score in scores)
            {
                if (score >= maxValue) 
                {
                    maxValue = score;
                }
            }

            return maxValue;
        }

        static int GetAverageScore(int[] scores)
        {
            int sum = 0;

            if (scores.Length == 0)
            {
                return 0;
            }

            foreach (int score in scores)
            {
                sum += score;
            }

            return sum/scores.Length;
        }

        static int GetIndexOf(int[] scores, int value)
        {
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i]==value)
                {
                    return i;
                }
            }

            return -1;
        }

        static int Sort(int[] scores)
        {
            for (int i = 0; i < scores.Length; i++)
            {
                int minIndex = i;

                for (int j = i; j < scores.Length; j++)
                {
                    if (scores[j]<scores[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // swap
                int temp = scores[i];
                scores[i] = scores[minIndex];
                scores[minIndex] = temp;
            }

            return 0;
        }

        static void Main(string[] args)
        {
            int[] scores = new int[5] { 10, 30, 40, 20, 50 };

            int highestScore = GetHighestScore(scores);
            Console.WriteLine(highestScore);

            int averageScore = GetAverageScore(scores);
            Console.WriteLine(averageScore);

            int index = GetIndexOf(scores, 20);
            Console.WriteLine(index);

            Sort(scores);

            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write("{0} ",scores[i]);
            }
        }
    }
}
