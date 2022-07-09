class AreTheySame
{
    public static bool comp(int[] a, int[] b)
    {
        if (a == null || b == null)
        {
            return false;
        }
        //The variable sums the squares of all the numbers in the array a
        int sum1 = 0;
        //Find the sum of all numbers in the array b
        int sum2 = 0;
        //Traverse the array b to sum
        for (int j = 0; j < b.Length; j++)
        {
            sum2 += b[j];
        }
        //Traverse the array a
        for (int i = 0; i < a.Length; i++)
        {
            //Define mark
            int tem = 0;
            //Get the square
            int aa = a[i] * a[i];
            //Add the squares
            sum1 += aa;
            for (int j = 0; j < b.Length; j++)
            {
                //Determine whether there is data that meets the conditions
                if (aa == b[j])
                {
                    //Judgment mark to ensure that it is executed once
                    if (tem == 0)
                    {
                        //mark
                        tem++;
                        //Invalidate eligible data to avoid duplication
                        b[j] = b[j] + 1;
                    }
                }
            }
            //Judgment mark, if there is no mark, return false
            if (tem == 0)
            {
                return false;
            }
        }
        //Judging the legality of the overall data
        if (sum1 != sum2)
        {
            return false;
        }
        //Return true if all the above conditions are passed
        return true;
    }

    public static void Main()
    {
        Console.WriteLine(AreTheySame.comp(new int[] { 121, 144, 19, 161, 19, 144, 19, 11 },
            new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 }));
    }
}