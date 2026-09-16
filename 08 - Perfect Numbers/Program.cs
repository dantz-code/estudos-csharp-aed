class Program
{
    static void Main()
    {
        // Números Perfeitos

        int Soma;

        for (int n = 1; n <= 1000; n++)
        {
            Soma = 0;

            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    Soma += i;
                }
            }
            if (Soma == n)
            {
                Console.WriteLine($"{Soma} This perfect like Jesus");
            }
        }
        Console.ReadKey();
    }
}