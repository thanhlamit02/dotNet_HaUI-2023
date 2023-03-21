internal class Program
{
    private static void Main(string[] args)
    {
        int n;
        double s1 = 0;
        double s2 = 0;
        Console.Write("Nhap n : ");
        n = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            s1 = s1 + i;
            s2 = s2 + (float)1 / i;
        }
        Console.WriteLine(s1 + "\n");
        Console.WriteLine(s2 + "\n");
    }
}