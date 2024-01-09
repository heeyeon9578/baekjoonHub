using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace programmers
{
    /// <summary>
    /// 받은 수 = n
    /// 남 = n* 배수 
    /// 여 = n의 좌우 대칭  
    /// 총 개수 (스위치 개수) = allNum
    /// 입력 받은 값 검사에서 몇 줄까지 스위치인지 검사
    /// 
    /// 
    /// /// </summary>
    class FileName
    {
        static void Main(string[] args)
        {
            StringBuilder result = new StringBuilder();
        
            int switchAll = int.Parse(Console.ReadLine()); //스위치 개수 <=100
            
            string[] switchNum = Console.ReadLine().Split(' ');  // 각 스위치 0 또는 1
            bool[] switchNumInt = new bool[switchAll]; //switchNum배열을 숫자로 만들 배열
            for (int j = 0; j < switchAll; j++)
            {
                if (switchNum[j] == "0")
                {
                    switchNumInt[j] = false;
                }
                else
                {
                    switchNumInt[j] = true;
                }
                
            }

            int studentNum = int.Parse(Console.ReadLine()); //학생 수 <=100
            for (int i = 0; i < studentNum; i++)
            {
                string[] studentInform = Console.ReadLine().Split(' ');
                int sex = int.Parse(studentInform[0]);
                int switchIndex = int.Parse(studentInform[1])-1;

                if (sex == 1) // 남자면,
                {
                    int countNum = 0; //배수(1씩 증가)
                    int finalNum = switchAll / (switchIndex+1);

                    while (countNum < finalNum)
                    {
                        int index = (switchIndex+1) * (++countNum); // 받은 수 * (1~finalNum)
                        switchNumInt[index-1] = !switchNumInt[index-1];
                    }
                } 
                else //여자면,
                {
                    if(switchIndex - 1 < 0 || switchIndex + 1>= switchNumInt.Length)
                    {
                        switchNumInt[switchIndex] = !switchNumInt[switchIndex];
                        continue;
                    }
                    if (switchNumInt[switchIndex - 1] != switchNumInt[switchIndex + 1])
                    {
                        //양 옆 스위치의 상태가 서로 다르므로, 본인꺼만 바꾸기
                        switchNumInt[switchIndex] = !switchNumInt[switchIndex];
                    }
                    else // 양 옆 스위치의 상태가 서로 같으면,
                    {
                        switchNumInt[switchIndex] = !switchNumInt[switchIndex];
                        switchNumInt[switchIndex - 1] = !switchNumInt[switchIndex - 1];
                        switchNumInt[switchIndex + 1] = !switchNumInt[switchIndex + 1];
                        int m = 2;
                        while (switchIndex - m >= 0 && switchIndex + m < switchNumInt.Length)
                        {
                            if (switchNumInt[switchIndex - m] == switchNumInt[switchIndex + m])
                            {
                                switchNumInt[switchIndex - m] = !switchNumInt[switchIndex - m];
                                switchNumInt[switchIndex + m] = !switchNumInt[switchIndex + m];
                                m++;
                            }
                            else
                            {
                                break;
                            }
                        }

                    } //else 끝

                }

            }

            

            if (switchNumInt.Length > 20)
            {
                int indexNum = switchNumInt.Length / 20;
                int b = 0;
                while (indexNum > 0)
                {
                    for (int c = b; c < b+20; c++)
                    {
                        int val = Convert.ToInt32(switchNumInt[c]);
                        result.Append(val.ToString());
                        result.Append(' ');
                    }
                    result.Remove(result.Length - 1, 1);
                    result.Append('\n');
                    indexNum--;
                    b += 20;
                }

                
                for (int c = b; c < switchNumInt.Length; c++)
                {
                    int val = Convert.ToInt32(switchNumInt[c]);
                    result.Append(val.ToString());
                    result.Append(' ');
                }
                result.Remove(result.Length - 1, 1);
               
            }
            else
            {
                for (int b = 0; b < switchNumInt.Length; b++)
                {

                    int val = Convert.ToInt32(switchNumInt[b]);
                    result.Append(val.ToString());
                    result.Append(' ');
                }
                result.Remove(result.Length - 1, 1);
            }
            
            Console.WriteLine(result.ToString());   

        }
    }
}
