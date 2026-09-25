// 4. Crie uma função que calcule recursivamente a potência, sendo base e expoente lidos pelo teclado.

class Potência
{
    public static int calculaPotência(int numeroBase, int numeroExpoente)
    {
        if (numeroExpoente == 0)
        {
            return 1;
        }
        else
        {
            return numeroBase * calculaPotência(numeroBase, numeroExpoente - 1);
        }
    }
}

class Program
{
    static void Main()
    {
        int result = Potência.calculaPotência(2, 3);
        Console.WriteLine(result);
    }
}
