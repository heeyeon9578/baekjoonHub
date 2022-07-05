using System;
using System.Text;

public class Program
{

    public static void Main()
    {
        StringBuilder sb = new StringBuilder();
        String inputs = Console.ReadLine();
        int a = int.Parse(inputs);
        int b = a;
        int num = 0;

        while (true)
        {
            
            int tlq = a / 10;
            int dlf = a - (tlq * 10);
            int sum = tlq + dlf;

            sum %= 10;
            a = dlf * 10 + sum;
            num++;

            if (b == a)
            {
                sb.Append(num);
                Console.WriteLine(sb.ToString());
                break;
            }
            
        }
       
        

    }

}
