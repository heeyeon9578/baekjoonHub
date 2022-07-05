using System;
public class Program
{

    public static void Main()
    {

        String[] a = Console.ReadLine().Split(' ');
        int c = int.Parse(Console.ReadLine());

        int h = int.Parse(a[0]);
        int s = int.Parse(a[1]);

        int c_h = c / 60;
        int c_s = c % 60;

        s += c_s;
        h += c_h;

        if (s >= 60)
        {            
            s -= 60;
            h += 1; 
        }
        if (h >= 24)
        {
            h -= 24;
        }
        Console.WriteLine(h + " " + s);
    }

}
