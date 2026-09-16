class Program
{
    static void Main()
    {
        double a, b, c;
        double Delta;
        double R1 = 0, R2 = 0;

        Console.Write("a =");
        a = double.Parse(Console.ReadLine());

        Console.Write("b =");
        b = double.Parse(Console.ReadLine());

        Console.Write("c = ");
        c = double.Parse(Console.ReadLine());

        Delta = CalcDelta(a, b, c);

        Console.Write($"\n Delta = {Delta}");

        if (Delta < 0)
        {
            Console.Write("\n Não existem Raízes Reais...");
        }
        else
        {
            CalcRaizes(a, b, Delta, ref R1, ref R2);

            Console.WriteLine($"Raiz 1: {R1}");
            Console.WriteLine($"Raiz 2: {R2}");
        }
    }
#region Funções
    static void CalcRaizes(double a, double b, double Delta, ref double R1, ref double R2)
    {
        R1 = (-b + Math.Sqrt(Delta)) / (2 * a);
        R2 = (-b - Math.Sqrt(Delta)) / (2 * a);
    }

    static double CalcDelta(double a, double b, double c)
    {
        return Math.Pow(b, 2) - 4 * a * c;
    }
}
#endregion