/* Problema 7

Um programa recebe um número inteiro e informa se ele é:

positivo e par;
positivo e ímpar;
negativo e par;
negativo e ímpar;
zero. */

class Program
{
    static void Main()
    {
        int n;

        Console.WriteLine("Insira um número inteiro");
        n = int.Parse(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("\nO número inserido é negativo");
            if (n % 2 != 0)
            {
                Console.WriteLine("\nE também é impar.");
            }
            else
            {
                Console.WriteLine("\nE também é par.");
            }
        }
        else if (n > 0)
        {
            Console.WriteLine("\nO número inserido é positivo");
            if (n % 2 == 0)
            {
                Console.WriteLine("\nE também é par.");
            }
            else
            {
                Console.WriteLine("\nE também é impar.");
            }
        }
        else
        {
            Console.WriteLine("\nErro: O número é igual a 0.");
        }
        Console.ReadKey();
    }
}