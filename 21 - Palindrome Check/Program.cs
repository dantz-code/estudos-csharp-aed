using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        string Texto;

        Console.WriteLine("Digite uma palavra");
        Texto = Console.ReadLine();

        if (TestaPalíndromo(Texto))
        {
            Console.WriteLine("É PALÍNDROMO!!");
        }
        else
        {
            Console.WriteLine("NÃO É PALÍNDROMO");
        }
        static bool TestaPalíndromo(string T)
        {
            if (T.Length <= 1)
            {
                return true;
            }
            if ( T[0] != T[T.Length - 1])
            {
                return false;
            }
            else
            {
                return TestaPalíndromo(T.Substring(1, T.Length - 2));
            }
        }
    }
}