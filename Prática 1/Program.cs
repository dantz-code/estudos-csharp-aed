/* Problema 6 — completo

Um programa recebe três números inteiros e precisa informar qual é o maior deles.

Mas agora você também precisa tratar os empates. */

class Program
{
    static void Main()
    {
        int numero1;
        int numero2;
        int numero3;

        Console.WriteLine("Insira um número inteiro");
        numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Insira outro número inteiro");
        numero2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Insira novamente um número inteiro");
        numero3 = int.Parse(Console.ReadLine());

        if (numero1 > numero2 && numero1 > numero3)
        {
            Console.WriteLine("Número 1 é maior que números 2 e 3.");
        }
        else if (numero2 > numero3 && numero2 > numero1)
        {
            Console.WriteLine($"Número 2 é maior que números 1 e 3.");
        }
        else if (numero3 > numero1 && numero3 > numero2)
        {
            Console.WriteLine("Número 3 é maior que números 1 e 2.");
        }
        else if (numero1 == numero2 && numero1 > numero3)
        {
            Console.WriteLine("Número 1 e número 2 empatam como maiores números.");
        }
        else if (numero1 == numero3 && numero1 > numero2)
        {
            Console.WriteLine("Número 1 e número 3 empatam como maiores números.");
        }
        else if (numero2 == numero3 && numero2 > numero1)
        {
            Console.WriteLine("Número 2 e número 3 empatam como maiores números.");
        }
        else
        {
            Console.WriteLine("Todos os números são iguais.");
        }

    }
}