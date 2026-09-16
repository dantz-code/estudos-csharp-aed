using System.IO.Pipelines;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número:");
        int n = int.Parse(Console.ReadLine());

        if (TestaPrimo(1, n, 0))
        {
            Console.WriteLine("Esse número é Primo!");
        }
        else
            Console.WriteLine("Esse número não é primo");

        Console.ReadKey();

        static bool TestaPrimo(int i, int n, int Div)
        {
            bool Result = true;

            if (n <= 1)
            {
                Result = false;
            }
            if (i <= n)
            {
                if (n % i == 0)
                {
                    Div++;
                }
            }
            Result = (Div <= 2) && TestaPrimo(i + 1, n, Div);
            
            return Result;
        }
    }
}