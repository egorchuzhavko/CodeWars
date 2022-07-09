using System;
public class Sum
{
    public int GetSum(int a, int b)
    {
        if(a > b)
        {
            int sum = 0;
            for (int i = b; i <= a; i++) sum += i;
            return sum;
        }
        else if(a < b)
        {
            int sum = 0;
            for (int i = a; i <= b; i++) sum += i;
            return sum;
        }
        else
            return a;
    }

    public static void Main()
    {
        Sum sum = new Sum();
        Console.WriteLine(sum.GetSum(0, 1));
    }
}