class Program
{

    static void Main()
    {
        int Fat = 1;
        int n;

        Console.WriteLine("n =");
        n = int.Parse(Console.ReadLine());

        Fat = CalcFat(n);

        Console.WriteLine($"Fatorial {Fat}");
    }

    static int CalcFat(int x)
    {
        int Result = 1;

        for (int i = 1; i <= x; i++)
        {
            Result *= i;
        }

        return Result;
    }
}