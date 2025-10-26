internal class Program
{
    private static void Main(string[] args)
    {
        int count1 = 0;
        int x;
        int sumd = 0;        for (x = 2; x <=8; x++)
        {
            for (int d = 1; d <= x; d++)
            {
                if (x % d == 0)
                {
                    if (d > 2)
                    {
                        count1++;
                    }
                }
            }
        }
        Console.WriteLine(count1);
    }
}