using System;

namespace baekioon
{
    class MainApp
    {
        static void Main()
        {
            int c = int.Parse(Console.ReadLine());
            for (int i = 0; i < c; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int studentNum = int.Parse(input[0]);
                int[] inputNum = new int[studentNum + 1];
                float sum = 0;
                float average = 0;

                for (int j = 0; j < studentNum + 1; j++)
                {
                    inputNum[j] = int.Parse(input[j]);
                    if (j >= 1)
                    {
                        sum += inputNum[j];
                    }
                }

                average = sum / (float)studentNum;
                float count = 0;

                for (int j = 0; j < studentNum + 1; j++)
                {
                    if (j >= 1 && inputNum[j] > average)
                    {
                        count++;
                    }
                }

                float result = count / (float)studentNum;

                Console.WriteLine("{0:#0.000%}", result);
            }
        }
    }
}