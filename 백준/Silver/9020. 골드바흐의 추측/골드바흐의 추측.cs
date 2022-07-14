using System;
using System.Text;

class B_Diary
{
    static void Main()
    {
        StringBuilder builder = new StringBuilder();
        bool[] sieve= new bool[10001];
        

        for (int i = 2; i < 10001; i++)   //에라토스테네스의 체
        {
              
            if(sieve[i]==false)
            { 
                for (int j = i+i; j < 10001; j += i)    //i의 배수전체 true
                {
                     sieve[j] = true;
                }
            }
        }

        int testcase = int.Parse(Console.ReadLine());

        for (int i = 0; i < testcase; i++)
        {
            int N = int.Parse(Console.ReadLine());
            int Num1 = N/2;
            int Num2 = N/2;
          
            while(true)
            {
                if (sieve[Num1] == false && sieve[Num2] == false)
                {
                    builder.Append(Num1 + " " + Num2 + "\n");
                    break;
                }
                Num1--;
                Num2++;
            }
          
        }
        Console.WriteLine(builder);
    }
}