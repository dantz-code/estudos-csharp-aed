// 5. Crie uma função recursiva que receba uma matriz e mostre o maior elemento par que ela possui.

class maiorPar
{
    public static int maiorNumeroPar(int[,] Matriz, int indiceLinha, int indiceColuna, int maior)
    {

        if (indiceColuna == Matriz.GetLength(1))
        {
            indiceColuna = 0;
            indiceLinha++;
        }

        if (indiceLinha == Matriz.GetLength(0))
        {
            return maior;
        }

        if (Matriz[indiceLinha, indiceColuna] % 2 == 0 && Matriz[indiceLinha, indiceColuna] > maior)
        {
            maior = Matriz[indiceLinha, indiceColuna];
            return maiorNumeroPar(Matriz, indiceLinha, indiceColuna + 1, maior);
        }
        else
        {
            return maiorNumeroPar(Matriz, indiceLinha, indiceColuna + 1, maior);
        }
    }
}

class Program
{
    static void Main()
    {
        int[,] Matriz = new int[4, 4];
        Random random = new Random();

        for (int i = 0; i < Matriz.GetLength(0); i++)
        {
            for (int j = 0; j < Matriz.GetLength(1); j++)
            {
                Matriz[i, j] = random.Next(1, 10);
            }
        }

        for (int i = 0; i < Matriz.GetLength(0); i++)
        {
            for (int j = 0; j < Matriz.GetLength(1); j++)
            {
                Console.WriteLine($"{Matriz[i, j]}");
            }
        }

        int Result = maiorPar.maiorNumeroPar(Matriz, 0, 0, 0);
        Console.WriteLine($"O Maior número par encontrado na Matriz é: {Result}");
    }
}