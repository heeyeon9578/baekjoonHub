using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Class1
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            int M = int.Parse(str[0]);
            int N = int.Parse(str[1]);
            int[][] Board = new int[M][];

            int Finalanswer = 64;
            int answer = 0;
            int a = 0;

            //흰색과 검은색을 0과 1로 바꾸는 과정
            for(int i=0; i<M; i++)
            {
                Board[i] = new int[N];
                string BW = Console.ReadLine();
                for(int j=0; j<N; j++)
                {
                    if (BW[j] == 'W')
                    {
                        Board[i][j] = 0;
                    }
                    else
                    {
                        Board[i][j] = 1;
                    }
                }
            }

            //8*8 체스판을 주어진 체스판 위에 올려놓고 한칸씩 움직이는 과정
            for(int i=0; i<M-7; i++)
            {
                for(int j=0; j<N-7; j++)
                {
                    //WB순서 확인
                    answer = 0;
                    a = 0;
                    for(int k=i; k<i+8; k++)
                    {
                        for(int l=j; l<j+8; l++)
                        {
                            if (Board[k][l] != a % 2)
                            {
                                answer++;
                            }

                            a++;
                        }

                        a++;
                    }

                    if(Finalanswer > answer)
                    {
                        Finalanswer = answer;
                    }

                    //BW 순서 확인
                    answer = 0;
                    a = 1;
                    for(int k=i; k<i+8; k++)
                    {
                        for(int l=j; l<j+8; l++)
                        {
                            if(Board[k][l] != a % 2)
                            {
                                answer++;
                            }
                            a++;
                        }

                        a++;
                    }
                    if(Finalanswer > answer)
                    {
                        Finalanswer = answer;
                    }

                }
            }

            Console.WriteLine(Finalanswer);

        }

        
    }
}
