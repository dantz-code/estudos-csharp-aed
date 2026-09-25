// 2. Faça uma função recursiva que mostre o menor número presente em um vetor de 20 posições.
// 3. Faça um programa que contenha uma função capaz de inverter uma string fornecida por um usuário.
// 4. Crie uma função que calcule recursivamente a potência, base e expoente sendo lidos pelo teclado.
class Recursividade
{    public static void inverterString(string x, int n)
    {
        if (n >= 0)
        {
            Console.WriteLine(x[n]);
            inverterString(x, n - 1);
        }
        else
        {
            Console.WriteLine("");
        }
    }
}
class Program
{
    static void Main()
    {
        int[] Vetor = new int[20];
        Random random = new Random();

        for (int i = 0; i < Vetor.Length; i++)
        {
            Vetor[i] = random.Next(2, 10);
        }

        int menor = Vetor[0];

        /* for (int i = 0; i < Vetor.Length; i++)
        {
            Console.WriteLine($"Vetor: {Vetor[i]}");
            Console.WriteLine();
        }

        Console.WriteLine($" Menor: {Recursividade.menorNumero(Vetor, 1, menor)}");
        */
        string palavra;

        Console.WriteLine("Digite uma palavra");
        palavra = Console.ReadLine();

        Recursividade.inverterString(palavra, palavra.Length - 1);
    }
}
