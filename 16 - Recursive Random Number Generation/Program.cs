class Program {
    static void Main()
    {
        // Sorteio simples de Números
        Random x = new Random();
        int Qtde;

        Qtde = 5;

        for (int i = 1; i <= Qtde; i++)
        {
            Console.Write($"{x.Next(1,50),7}");
        }
        Console.ReadKey();

        Mostra(Qtde);

        Console.ReadKey();
    }

    static void Mostra(int n)
    {
        Random x = new Random();
        Console.Write($"{x.Next(1,50),7}");

        if (n != 1)
        {
            Mostra(n - 1);
        }
    }
}