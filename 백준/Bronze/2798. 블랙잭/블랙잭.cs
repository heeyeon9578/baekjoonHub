using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Class1
    {
        static void Main(string[] args)
        {
            //N,M 값 입력
            string[] N_M = Console.ReadLine().Split();
            int N = int.Parse(N_M[0]);
            int M = int.Parse(N_M[1]);

            //카드에 쓰여진 수 입력
            string[] nums = Console.ReadLine().Split();
            int[] numsInt = new int[N];

            //세 개의 카드의 값을 더할 sum 변수
            int sum = 0;
            //답을 알아낼 temp 변수
            int temp = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                numsInt[i] = int.Parse(nums[i]);
            }
            //세 번의 for 루프를 통해 세개의 카드를 뽑을 수 있음
            for(int i=0; i<N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    for(int k=0; k < N; k++)
                    {
                        //서로 다른 수를 선택해야 하므로, 인덱스 값이 달라야 함
                        if(i != j && i != k && j != k)
                        {
                            sum = numsInt[i] + numsInt[j] + numsInt[k];
                        }
                        //M보다 작거나 같은데 이전에 temp에 저장된 값보다 커야함
                        if (sum <= M && sum>temp)
                        {
                            temp = sum;
                        }
                    }
                }
            }

            Console.WriteLine(temp);


        }
    }
}
