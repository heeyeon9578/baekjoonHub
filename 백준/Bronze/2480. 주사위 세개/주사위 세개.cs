using System;
public class Program
{

    public static void Main()
    {

        String[] inputs = Console.ReadLine().Split(' ');
        
        int a = int.Parse(inputs[0]);
        int b = int.Parse(inputs[1]);
        int c = int.Parse(inputs[2]);
        int answer;
        if(a==b && b==c &&  c==a)
        {
            answer = 10000 + (a) * 1000;
        }else if (a == b)
        {
            answer = 1000 + a*100;
        }else if (b == c)
        {
            answer = 1000 + b * 100;

        }else if (c == a)
        {
            answer = 1000 + a * 100;
        }
        else
        {
            answer = (a > b ? a : b) > c ? (a > b ? a : b) : c;
            answer = answer* 100;
        }

        Console.WriteLine(answer);
    }

}
