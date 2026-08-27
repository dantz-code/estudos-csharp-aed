class Program
{
    static void Main()
    {
        int P1, P2;
        int Soma;
        int Quadrado;

        for (int n = 1000; n <= 9999; n++)
        {
            P1 = n / 100;
            P2 = n % 100;

            Soma = P1 + P2;

            Quadrado = Soma * Soma;

            if (Quadrado == n)
            {
                Console.WriteLine($"O Número {n} possui essa característica...");
            }
        }
    }
}