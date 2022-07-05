using System;
using System.Text;

public class Program
{

    public static void Main()
    {
        StringBuilder sb = new StringBuilder();
        String[] inputs = Console.ReadLine().Split(' ');
        int a = int.Parse(inputs[0]);
        int b = int.Parse(inputs[1]);
        String[] inputs_1 = Console.ReadLine().Split(' ');
        for (int i = 0; i < a; i++)
        {
            if (int.Parse(inputs_1[i]) < b)
            {
                sb.Append(inputs_1[i] + " ");
            }
            
        }

        Console.WriteLine(sb.ToString());   
        

    }

}
