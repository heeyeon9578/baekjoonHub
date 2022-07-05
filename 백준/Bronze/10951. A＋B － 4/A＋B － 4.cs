using System;
using System.Text;

public class Program
{

    public static void Main()
    {

        while (true)
        {
            StringBuilder sb = new StringBuilder();
            String inputs = Console.ReadLine();

            if (inputs == null)
            {
                return;
            }
            String[] inputs_1 = inputs.Split(' ');
            int a = int.Parse(inputs_1[0]);
            int b = int.Parse(inputs_1[1]);
 
            sb.Append(a + b);

            Console.WriteLine(sb.ToString());
        }
       
        

    }

}
