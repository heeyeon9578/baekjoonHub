using System;
using System.Text;

namespace beakjoon
{
    class MainClass
    {
        static StringBuilder sb = new StringBuilder();
        static int cnt = 0;

        public static void Hanoi(int h, int start, int assist, int goal)
        {
            if(h == 1)
            {
                sb.Append($"{start} {goal}\n");
                cnt++;
            }
            else
            {
                // 가장 큰 원판을 제외한 원판을 start -> assist 로 이동
                Hanoi(h - 1, start, goal, assist);

                // 가장 큰 원판을 옮겼을 때 경로를 출력
                sb.Append($"{start} {goal}\n");
                cnt++;

                // 가장 큰 원판을 제외한 원판을 assist -> goal 로 이
                Hanoi(h - 1, assist, start, goal);
            }
        }

        public static void Main(string[] args)
        {
            string temp = Console.ReadLine();

            int height = int.Parse(temp);


            Hanoi(height, 1, 2, 3);

            sb.Insert(0, $"{cnt}\n");

            Console.WriteLine(sb);
        }
    }
}