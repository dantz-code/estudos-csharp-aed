class Program
{
    static void Main()
    {
        int [] Vetor = {4, 7, 9, 8, 2, 4, 6};
        int i;

        Crescente(Vetor, 0);

        Decrescente(Vetor, Vetor.Length);


        static void Crescente(int [] V, int i)
        {
            if (V.Length > i)
            {
                Console.WriteLine($"\nVetor crescente: {V[i]}");
                Crescente(V, ++i);
            }
        }

        static void Decrescente(int [] V, int i)
        {
            if (i > 0)
            {
                Console.WriteLine($"\nVetor decrescente: {V[i - 1]}");
                Decrescente(V, --i);
            }
        }
    }
}