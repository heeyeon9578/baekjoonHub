using System;
public class Program
{

    public static void Main()
    {

        String inputs = Console.ReadLine();
        int a = Convert.ToInt32(inputs);

        if(a >100 || a < 0) { return; }
        if (90<=a)
        {
            Console.WriteLine("A");
        }else if(80<=a)
        {
            Console.WriteLine('B');
        }
        else if( 70<=a)
        {
            Console.WriteLine("C");
        }
        else if(60 <= a){
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }

    }
}
