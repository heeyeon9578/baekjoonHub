using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace baekjoon1620
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
						//딕셔너리 사용
            Dictionary<string, string> poket = new Dictionary<string, string>();
            Dictionary<string, int> pokets = new Dictionary<string, int>();
            StringBuilder sb = new StringBuilder();
						//포켓몬 들을 받는 포룹
            for (var i = 0; i < int.Parse(inputs[0]); i++)
            {
                string input = Console.ReadLine();
								//첫번째 딕셔너리<숫자, 포켓몬>
                poket.Add((i+1).ToString(), input);
								//두번째 딕셔너리<포켓몬, 숫자>
                pokets.Add(input, i+1);
            }

            for (var i = 0; i < int.Parse(inputs[1]); i++)
            {
								//질문 받아오기
                string ques = Console.ReadLine();
                //만약 숫자들이라면 쳣번째 딕셔너리에서 벨류값검색
                if(poket.ContainsKey(ques))
                {
                    sb.AppendLine(poket[ques]);
                }
								//스트링 이라면 두번째 띡셔너리에서 벨류값 검색
                else if (pokets.ContainsKey(ques))
                {
                    sb.AppendLine(pokets[ques].ToString());
                }
            }

            Console.WriteLine(sb.ToString());

        }
    }
}