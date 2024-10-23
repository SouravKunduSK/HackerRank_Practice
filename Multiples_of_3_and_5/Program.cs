namespace Multiples_of_3_and_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(CalculateSum(n));
            }
        }
        static long CalculateSum(int num)
        {
            if (num <= 0)
                return 0;

            return SumOfMultiplies(3, num) + SumOfMultiplies(5, num) - SumOfMultiplies(15, num);
        }

        static long SumOfMultiplies(int n, int num)
        {
            long k = (num - 1) / n;
            return (n * k * (k + 1)) / 2;
        }
    }
}
