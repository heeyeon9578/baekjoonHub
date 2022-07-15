using System;
using System.Text;

namespace WB
{
    class Program
    {
        static char[,] map = new char[3000, 3000];
        public static void Main(string[] args)
        {
            //N값 입력
            int N = int.Parse(Console.ReadLine());

            //초기화
            Init(N);

            //별 채우기
            FillStar(N, 0, 0);

            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    builder.Append(map[i, j]);
                }

                builder.AppendLine();
            }

            Console.WriteLine(builder.ToString());
        }

        //맵을 초기화 합니다. 입력된 n값에 맞게 초기화합니다.
        static void Init(int n)
        {
            for(int i=0; i<n; i++)
            {
                for(int j=0; j<n; j++)
                {
                    map[i, j] = ' ';
                }
            }
        }

        //별을 채웁니다.
        static void FillStar(int n, int x, int y)
        {
            if (n == 1)
            {
                map[x, y] = '*';
                return;
            }

            int div = n / 3;

            for(int i=0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    if(i==1 && j == 1)
                    {
                        continue;
                    }
                    FillStar(div, x+(div*i), y+(div*j));   
                }
            }
            return;
        }
    }
}