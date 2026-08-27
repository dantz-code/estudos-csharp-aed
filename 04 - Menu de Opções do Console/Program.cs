using System.Threading;
class Program
{
    static void Main()
    {
        int Op = 0;

        do
        {
            Console.Clear();

            Console.WriteLine("\n Menu de Opções:");

            Console.WriteLine("1 - Toca um Beep");

            Console.WriteLine("2 - Troca a Cor da Letra e Fundo");

            Console.WriteLine("3 - Altera o Título da Janela");

            Console.WriteLine("4 - Sair");

            Console.Write("\n Digite uma Opção:");
            Op = int.Parse(Console.ReadLine());

            switch (Op)
            {
                case 1:
                    Console.Beep();
                    Console.Beep();

                    break;

                case 2:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Texto na cor preta com fundo azul...");

                    Console.ReadKey();

                    Console.ResetColor();

                    Console.WriteLine("Texto na cor normal...");

                    break;

                case 3:
                    Console.Title = "SI/ADS PUC Minas Betim";
                    Console.ReadKey();

                    break;

                case 4:
                    Console.WriteLine("Saindo do Programa...");
                    Thread.Sleep(2000);

                    break;
            }
            Console.WriteLine("\n ESC para Sair ou Tecla para Continuar...");
        } while (Console.ReadKey().Key != ConsoleKey.Escape);
    }
}