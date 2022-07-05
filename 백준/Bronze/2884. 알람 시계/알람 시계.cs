using System;
public class Program
{

    public static void Main()
    {

        String[] a = Console.ReadLine().Split(' ');
        int h = int.Parse(a[0]);
        int s = int.Parse(a[1]);

        int s1 = s - 45;
        if(s1 < 0)
        {
            s1 = 60 + s1;
            h = h - 1; 
        }
        if(h < 0)
        {
            h += 24;
        }

        Console.WriteLine(h+" "+s1);
    }

}
