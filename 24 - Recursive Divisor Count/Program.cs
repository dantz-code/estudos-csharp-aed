class Program
{
    static void Main()
    {
        int n;
        int QtdeDiv;

        Console.WriteLine(" n = ");
        n = int.Parse(Console.ReadLine());

        QtdeDiv = ContaDivisores(1, n);

        Console.WriteLine($" Qtde de Divisores: {QtdeDiv}");

        Console.ReadKey();

        static int ContaDivisores(int Div, int n)
        {
            int Qtde = 0;

            if (Div <= n)
            {
                if (n % Div == 0)
                {
                    Qtde += 1 + ContaDivisores(Div + 1, n);
                }
                else
                {
                    Qtde += 0 + ContaDivisores(Div + 1, n);
                }
            }

            return Qtde;
        }
    }
}