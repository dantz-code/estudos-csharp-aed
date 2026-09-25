class Bicicleta
{
    private int id;
    private string Modelo;
    private bool Disponivel;
    private int TempoUso;

    public Bicicleta(int id, string modelo)
    {
        this.id = id;
        this.Modelo = modelo;
        this.Disponivel = true;
        this.TempoUso = 0;
    }

    public void Alugar()
    {
        if (Disponivel)
        {
            Disponivel = false;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bicicleta alugada com sucesso!");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Bicicleta já está alugada!");
            Console.ResetColor();
        }
    }

    // Metodo para devolver a bicicleta
    public void DevolverBiclicleta(int Minutos)
    {
        if (!Disponivel)
        {
            if (Minutos > 0)
            {
                TempoUso += Minutos;

                Disponivel = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Bicicleta devolvida com sucesso");
                Console.ResetColor();
            }

        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("A Bicicleta não está alugada");
            Console.ResetColor();
        }
    }
    public void ExibirDados()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Disponível: {(Disponivel ? "Sim" : "Não")}");
        Console.WriteLine($"Tempo total de uso: {TempoUso} Minutos");
        Console.ResetColor();
    }

    public bool EstaDisponivel()
    {
        return Disponivel;
    }

    public double CalcularValorArrecado()
    {
        return TempoUso * 0.5;
    }
}
class Program
{
    static void Main()
    {
        Bicicleta minhaBike = new Bicicleta(5, "Caloi");

        minhaBike.ExibirDados();
        Console.WriteLine();

        minhaBike.Alugar();
        Console.WriteLine();

        minhaBike.DevolverBiclicleta(30);
        Console.WriteLine();

        minhaBike.ExibirDados();
        Console.WriteLine();
    }
}
