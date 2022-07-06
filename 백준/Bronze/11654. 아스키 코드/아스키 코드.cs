using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{

    public static void Main()
    {
        //첫째 줄에 입력받은 문자를 아스키 코드로 출력한다.
        char a = Convert.ToChar(Console.ReadLine());
        int ascii = Convert.ToInt32(a);
        Console.WriteLine(ascii);

    }
}
