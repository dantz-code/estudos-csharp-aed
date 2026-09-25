// 1. Faça uma função recursiva capaz de imprimir em tela a soma dos elementos de um vetor de 20 posições composto de números aleatórios.

class Program
{
    static void Main()
    {
        int [] JesuseORei = new int [20];
        Random Jesus = new Random();


        for (int i = 0; i < JesuseORei.Length; i++)
        {
            JesuseORei[i] = Jesus.Next(1,10);
        }

        for (int i = 0; i < JesuseORei.Length; i++)
        {
            Console.WriteLine($"Vetor: {JesuseORei[i]}");
        }

        static int somaElementos (int [] Vetor, int soma, int n)
        {
            if (Vetor.Length == n)
            {
                Console.WriteLine($"A soma total dos elementos do vetor é {soma}");
            }

            if (Vetor.Length > n)
            {
                soma += Vetor[n];
                return somaElementos(Vetor, soma, n + 1);
            }

            return soma;
        }

        somaElementos(JesuseORei, 0, 0);
    }
}