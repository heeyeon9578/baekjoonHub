using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

public class Program
{
    public static void Main()
    {
        //두 개의 값 사이에서 소수찾기
        String[] str = Console.ReadLine().Split(' ');
        int M = int.Parse(str[0]);  
        int N = int.Parse(str[1]);
        StringBuilder st = new StringBuilder();
        Boolean[] prime = new Boolean[N+1];
        get_prime();
        for(int i=M; i <= N; i++)
        {
            //false = 소수
            if (!prime[i]) st.Append(i+"\n");
        }

        Console.WriteLine(st.ToString());

        //에라토스테네스의 체 알고리즘
        void get_prime()
        {
            //true = 소수아님, false = 소수
            prime[0] =prime[1] = true;

            for(int i=2; i<= Math.Sqrt(prime.Length); i++)
            {
                if (prime[i]) continue;
                for(int j=i*i; j<prime.Length; j+= i)
                {
                    prime[j] = true;    
                }
            }
        }
    }
}
