/* class Program
{
    static void Main()
    {
        int n;
        int Result;

        Console.WriteLine("n = ");
        n = int.Parse(Console.ReadLine());

        Result = somaDeUmAtéN(1, n, 0);

        Console.WriteLine($"A soma de 1 até {n} é: {Result}");

        Console.ReadKey();

        static int somaDeUmAtéN(int i, int n, int soma)
        {
            if ( n >= i)
            {
                soma += i;
                return somaDeUmAtéN( ++i, n, soma);
            }
            else
            {
                return soma;
            }
        }
    }
}

class Program
{
    static void Main()
    {
        int n;
        int Result;

        Console.WriteLine("n = ");
        n = int.Parse(Console.ReadLine());

        Result = numerosParesAtéN(1, n, 0);

        Console.WriteLine($"A quantidade de números pares de 1 até {n} é: {Result}");

        Console.ReadKey();

        static int numerosParesAtéN(int i, int n, int qtdePares)
        {
            if (n >= i)
            {
                if (i % 2 == 0)
                {
                    qtdePares++;
                    return numerosParesAtéN(++i, n, qtdePares);
                }
                else
                {
                    return numerosParesAtéN(++i, n, qtdePares);
                }
            }
            return qtdePares;
        }
    }
} */
