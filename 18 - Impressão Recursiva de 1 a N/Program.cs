class Program
{
    static void Main()
    {
        Console.Clear();

        Console.Write("a =");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Green;

        Imprimir("O valor de n é: ", n, 1);

        Console.ResetColor();

        Console.ReadKey();

        static void Imprimir(string text, int a, int b)
        {
            if (a >= b)
            {
                Console.WriteLine($"Texto: {b}");
                b++;


                Imprimir(text, a , b);
            }
        }
    }
}