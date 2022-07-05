using System;
public class Program
{

    public static void Main()
    {

        String inputs = Console.ReadLine();
        int a = Convert.ToInt32(inputs);

        if(a%4==0 && (a%100 !=0 || a % 400 == 0))
        {
            Console.WriteLine(1);
        }
        else { Console.WriteLine(0); }

    }
}
