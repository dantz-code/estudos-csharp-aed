class Program
{
    static void Main()
    {
        int i = 1;

        while ( i <= 10)
        {
            Console.Write($"{i,7}");
            i++;
        }

        Console.ReadKey();

        Console.WriteLine("\n");
        
    }
}