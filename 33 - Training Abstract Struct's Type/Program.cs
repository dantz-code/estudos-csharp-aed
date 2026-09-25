class Curso
{
    public string nomeCurso;
    public string nomeDoCoordenador;
    public double cargaHoraria;
    public string dataDeCriacao;

    private int _valorMensalidade;
    public int valorMensalidade
    {
        get
        {
            return _valorMensalidade;
        }
        set
        {
            if (value > 0)
            {
                _valorMensalidade = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Curso[] cursos = new Curso[4];

            cursos[0] = new Curso();
            cursos[1] = new Curso();
            cursos[2] = new Curso();
            cursos[3] = new Curso();

            cursos[0].nomeCurso = "Sistemas de Informação";
            cursos[0].nomeDoCoordenador = "Bernardo Jeunon de Alencar";
            cursos[0].cargaHoraria = 400;
            cursos[0].dataDeCriacao = "06/02/1996";
            cursos[0].valorMensalidade = 1600;

            cursos[1].nomeCurso = "Analise e Desenvolvimento de Sistemas";
            cursos[1].nomeDoCoordenador = "Fabio";
            cursos[1].cargaHoraria = 200;
            cursos[1].dataDeCriacao = "23/08/2003";
            cursos[1].valorMensalidade = 1000;

            cursos[2].nomeCurso = "Ciencias da Computação";
            cursos[2].nomeDoCoordenador = "Amalia Vasconcelos";
            cursos[2].cargaHoraria = 600;
            cursos[2].dataDeCriacao = "28/06/1992";
            cursos[2].valorMensalidade = 2000;
            
            cursos[3].nomeCurso = "Teste";
            cursos[3].nomeDoCoordenador = "Teste";
            cursos[3].cargaHoraria = 0;
            cursos[3].dataDeCriacao = "0/00/00";
            cursos[3].valorMensalidade = -2000;

            foreach (Curso x in cursos)
            {
                if (x.valorMensalidade > 1500)
                {
                    Console.WriteLine($"Cursos com mensalidade superior a 1500: {x.nomeCurso}");
                }
            }
        }
    }
}