using System;
using System.Text;

namespace _4948
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string str = Console.ReadLine();
                if (str[0] == '0')
                {
                    break;
                }
                int M = int.Parse(str);
                int N = M * 2;
                int cnt = 0;
                int[] arr = new int[N + 1];

                for (int i = 2; i < N + 1; i++)
                {
                    arr[i] = i;
                }

                for (int i = 2; i < N + 1; i++)
                {
                    if (arr[i] != 0)
                    {
                        for (int j = i * 2; j < N + 1; j += i)
                        {
                            arr[j] = 0;
                        }
                    }
                }

                for (int i = M + 1; i < N + 1; i++)
                {
                    if (arr[i] == 0)
                    {

                    }
                    else
                    {
                        cnt++;
                    }
                }
                Console.WriteLine(cnt);
            }
        }
    }
}