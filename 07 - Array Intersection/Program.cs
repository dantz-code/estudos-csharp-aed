class Program
{
    static void Main()
    {
        int [] vetorA = new int [5];
        int [] vetorB = new int [5];
        int [] vetorC = new int [5];
        int PosIns = 0;

        vetorA = [3, 2, 9, 0, 6];
        vetorB = [4, 2, 9, 3, 6];

        bool Existe;
        for (int i = 0; i < vetorA.Length; i++)
        {
            Existe = false;

            for (int j = 0; j < vetorA.Length; j++)
            {
                if (vetorA[i] == vetorB[j])
                {
                    Existe = true;
                }
            }

            if(Existe == true)
            {
                vetorC[PosIns++] = vetorA[i];
            }
        }

        for (int i = 0; i < vetorA.Length; i++)
        {
            Console.WriteLine($"Vetor A: {vetorA[i]}");
            Console.WriteLine($"Vetor B: {vetorB[i]}");
        }

        for (int i = 0; i < PosIns; i++)
        {
            Console.WriteLine($"Vetor C: {vetorC[i]}");
        }
    }
}