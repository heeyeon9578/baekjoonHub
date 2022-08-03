using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Project1
{
    class Class1
    {
        static void Main(string[] args)
        {
            //[1]입력
            int num = int.Parse(Console.ReadLine());
            int[] numArray = new int[num];

            for(int i=0; i<num; i++)
            {
                numArray[i] = int.Parse(Console.ReadLine());
            }
            StringBuilder sb = new StringBuilder();
            //합계
            int sum = 0;
            //산술평균
            decimal avg = 0;
            //중앙값
            float middle = 0;
            //최빈값
            int maxmax = 0;
            int[] plusNumArray = new int[8002];
            int count = 0;
            //범위
            int maxmin = 0;

            //[2]처리
            //합계 구하기
            for(int i=0; i<num; i++)
            {
                sum += numArray[i];
            }
            //평균 구하기
            avg = (decimal) sum / num;

            //정렬
            Array.Sort(numArray);
            
            middle = numArray[(num / 2)];

            maxmin = numArray[num - 1] - numArray[0];


            //최빈값 구하기
            //-4000~4000 배열에 값 넣어주기, 인덱스는 0~8000
            for (int j = 0; j < num; j++)
            {
                for(int i=-4000; i< 4001; i++)
                {
                    if(numArray[j] == i)
                    {
                        plusNumArray[i + 4000]++;
                    }


                }
                
            }

            //각 숫자별로 몇개 있는지 배열의 최대값
            int max = plusNumArray.Max();

            //최빈값이 2개이상인지 검사하기
            for (int j = 0; j <8002; j++)
            {
                if (plusNumArray[j] == max)
                {
                   
                    count++;
                }

                if (count > 1)
                {
                    break;
                }
                
            }

            //2개일때는 제일 큰 값을 0으로 초기화 해주고, 두번째 값을 구하기
            if (count == 2)
            {
                for (int j = 0; j < 8002; j++)
                {
                    if (plusNumArray[j] == max)
                    {
                        plusNumArray[j] = 0;
                        break;
                    }

                }

                //maxmax은 최빈값의 인덱스를 저장
                maxmax = Array.IndexOf(plusNumArray, plusNumArray.Max());
            }
            else
            {
                //maxmax은 최빈값의 인덱스를 저장
                maxmax = Array.IndexOf(plusNumArray, plusNumArray.Max());
            }
            sb.Append(Math.Round(avg, 0) + "\n");
            sb.Append(middle + "\n");
            sb.Append((maxmax - 4000) + "\n");
            sb.Append(Math.Abs(maxmin));
            //[3]결과
            /*            Console.WriteLine(Math.Round(avg));
                        Console.WriteLine(middle);
                        Console.WriteLine(maxmax-4000);
                        Console.WriteLine(Math.Abs(maxmin));*/

            Console.WriteLine(sb);
            

        }

        
    }
}
