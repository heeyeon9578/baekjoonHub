using System;
using System.Text;

public class Program
{

    public static void Main()
    {

        while (true)
        {
            StringBuilder sb = new StringBuilder();
            String[] inputs = Console.ReadLine().Split(' ');
            int a = int.Parse(inputs[0]);
            int b = int.Parse(inputs[1]);
            if (a == 0 && b == 0)
            {
                return;
            }
            sb.Append(a + b);

            Console.WriteLine(sb.ToString());
        }
       
        

    }

}
