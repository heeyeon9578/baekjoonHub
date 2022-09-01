using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Project2
{
    class Class1
    {
        static void Main(string[] args)
        {
            //입력 
            String[] str = Console.ReadLine().Split();
            int w = int.Parse(str[0]);
            int h = int.Parse(str[1]);
            int x = int.Parse(str[2]);
            int y = int.Parse(str[3]);
            int p = int.Parse(str[4]);
            int[,] xys = new int[p,2];
            int num = 0;

            for(int i=0; i<p; i++)
            {
                string[] str1 = Console.ReadLine().Split();
                for(int j=0; j<2; j++)
                {
                    xys[i, j] = int.Parse(str1[j]);
                }
            }

            //과정
            //0. 준비
            int radius = h / 2; //원의 반지름
            // 원의 중심
            int ra_x = x;
            int ra_y = y + radius;

            //원의 중심2
            int ra_x2 = x + w;
            int ra_y2 = y + radius;




            //1. 좌표 범위 구하기
            // 1) 직사각형 
            //선수의 수만큼 for문 돌면서 검사하기
            for (int i = 0; i < p; i++)
            {
                if(xys[i,0] >= x && xys[i,0]<= x + w)
                {
                    if(xys[i,1] >= y && xys[i,1]<= y + h)
                    {
                        num++;
                        continue;
                    }
                }else if (Math.Sqrt(Math.Pow(xys[i,0]-ra_x, 2)+Math.Pow(xys[i,1]-ra_y,2))<= radius) //2) 원
                {
                    num++;
                    continue;
                }
                else if (Math.Sqrt(Math.Pow(xys[i, 0] - ra_x2, 2) + Math.Pow(xys[i, 1] - ra_y2, 2)) <= radius)
                {
                    num++;
                    continue;
                }
            }

            //출력

            Console.WriteLine(num);
        }
    }
}