using System;
using System.Text;

class B_Diary
{
    static int Cal(int num1,int num2)
    {
        int[,] room = new int[15, 15];   

       
        for(int i=1;i<num1+1;i++)
        {
            room[i, 1] = 1;
            
        }       

        for(int i=1;i<num2+1;i++)
        {
            room[0, i] = i;
        }

        for (int i = 1; i < num1+1; i++)                                     
        {   
            for (int j = 2; j < num2+1; j++)     
            {   
                room[i,j] = room[i,(j - 1)] + room[(i - 1),j];              
            }
        }
        return room[num1, num2];       
    }


    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        StringBuilder builder = new StringBuilder();

        for(int i=0;i<input;i++)
        {
            int k = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            builder.Append(Cal(k, n) + "\n");
            
        }
        Console.WriteLine(builder);
               
    }
}