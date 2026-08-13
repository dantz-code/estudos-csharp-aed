class Program
{
    static void Main()
    {
        string[] nomePessoa = new string[2];
        char[] sexoPessoa = new char[2];
        double[] salarioPessoa = new double[2];
        double maiorSalarioHomens = 0;
        double maiorSalarioMulheres = 0;
        int qtddHomens = 0;
        int qtddMulheres = 0;
        double mediaSalarioHomens;
        double mediaSalarioMulheres;
        double somaSalarioMulheres = 0;
        double somaSalarioHomens = 0;

        for (int i = 0; i < nomePessoa.Length; i++)
        {
            Console.WriteLine("Digite o seu nome");
            nomePessoa[i] = Console.ReadLine();

            Console.WriteLine("Informe o seu sexo: (M/F)");
            sexoPessoa[i] = char.Parse(Console.ReadLine());

            Console.WriteLine("Informe o seu salario");
            salarioPessoa[i] = double.Parse(Console.ReadLine());
        }

        for (int i = 0; i < nomePessoa.Length; i++)
        {
            if (sexoPessoa[i] == 'F')
            {
                somaSalarioMulheres += salarioPessoa[i];
                if (salarioPessoa[i] > maiorSalarioMulheres)
                {
                    maiorSalarioMulheres = salarioPessoa[i];
                }
                qtddMulheres++;

            }
            else
            {
                somaSalarioHomens += salarioPessoa[i];
                if (salarioPessoa[i] > maiorSalarioHomens)
                {
                    maiorSalarioHomens = salarioPessoa[i];
                }
                qtddHomens++;
            }
        }

        mediaSalarioHomens = somaSalarioHomens / qtddHomens;
        mediaSalarioMulheres = somaSalarioMulheres / qtddMulheres;

        for (int i = 0; i < nomePessoa.Length; i++)
        {
            Console.WriteLine($"\nLista de pessoas: {nomePessoa[i]}");
            Console.WriteLine($"\nLista de sexos: {sexoPessoa[i]}");
            Console.WriteLine($"\nLista de salários: {salarioPessoa[i]}");
        }
        Console.WriteLine($"\n Maior salário Masculino {maiorSalarioHomens}");
        Console.WriteLine($"\n Maior salário Feminino {maiorSalarioMulheres}");
        Console.WriteLine($"\n Media salárial entre os homens: {mediaSalarioHomens}");
        Console.WriteLine($"\n Media salárial entre as mulheres: {mediaSalarioMulheres}");

        Console.ReadKey();
    }
}