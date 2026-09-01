class Program
{
    static void Main()
    {
        int x;

        Console.WriteLine("x = ");
        x = int.Parse(Console.ReadLine());

        int Result = somaAtéX(x, 1, 0);

        Console.WriteLine($"\n Soma: {Result}");


        static int somaAtéX(int x, int a, int sum)
        {
            if (x >= a)
            {
                sum += a;
                return somaAtéX(x, ++a, sum);
            }

            return sum;
        }
    }
}