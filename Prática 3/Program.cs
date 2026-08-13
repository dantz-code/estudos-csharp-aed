class Program
{
    static void Main()
    {
        int n1, n2, n3;

        Console.WriteLine("Informe um número inteiro");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe outro número inteiro");
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe novamente outro número inteiro");
        n3 = int.Parse(Console.ReadLine());

        if (n1 <= n2 && n1 <= n3)
        {
            if (n2 <= n3)
            {
                Console.WriteLine($"\nOrdem Crescente: {n1} {n2} {n3}");
            }
            else
            {
                Console.WriteLine($"\nOrdem Crescente: {n1} {n3} {n2}");
            }
        }
        if (n2 <= n1 && n2 <= n3)
        {
            if (n1 <= n2)
            {
                Console.WriteLine($"\nOrdem Crescente: {n2} {n2} {n3}");
            }
            else
            {
                Console.WriteLine($"\nOrdem Crescente: {n2} {n3} {n2}");
            }
        }

        if (n3 <= n1 && n3 <= n2)
        {
            if (n1 <= n2)
            {
                Console.WriteLine($"\nOrdem Crescente: {n3} {n1} {n2}");
            }
            else
            {
                Console.WriteLine($"\nOrdem Crescente: {n3} {n3} {n1}");
            }
        }
    }
}