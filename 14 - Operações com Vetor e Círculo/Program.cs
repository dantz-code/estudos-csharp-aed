class Program
{
    static void Main()
    {
        int[] Vetor = new int[10];

        Random x = new Random();

        int Maior, Menor;
        double Media = 0;

        double Raio;
        double Área = 0, Perimetro = 0;

        for (int i = 0; i < 10; i++)
        {
            Vetor[i] = x.Next(0, 50);

            Console.WriteLine($"{Vetor[i],7}");
        }

        Console.ReadKey();

        Maior = achaMaior(Vetor);
        Menor = achaMenor(Vetor);
        Media = calcMedia(Vetor, ref Media);

        Console.WriteLine($"Maior = {Maior}");
        Console.WriteLine($"Menor = {Menor}");
        Console.WriteLine($"Média = {Media:F2}");

        Console.Write("Raio do Círculo: ");
        Raio = double.Parse(Console.ReadLine());

        (Área, Perimetro) = calcÁreaPerimetro(Raio);

        Console.WriteLine($"\nÁrea {Área}");
        Console.WriteLine($"Perimetro {Perimetro}");


        static int achaMaior(int[] v)
        {
            int Maior = v[0];

            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] > Maior)
                {
                    Maior = v[i];
                }
            }

            return Maior;
        }

        static int achaMenor(int[] v)
        {
            int Menor = v[0];

            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] < Menor)
                {
                    Menor = v[i];
                }
            }

            return Menor;
        }

        static double calcMedia(int[] v, ref double Media)
        {
            int Soma = 0;

            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] > 0 )
                {
                    Soma += v[i];
                }
            }

            Media = Soma / v.Length;
            return Media;
        }

        static (double, double) calcÁreaPerimetro(double r)
        {
            double a = Math.PI * Math.Pow(r, 2);
            double p = 2 * Math.PI * r;

            return (a, p);
        }


    }
}