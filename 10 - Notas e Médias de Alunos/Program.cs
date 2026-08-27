static void Main(string[] Args)
        {
            int[,] Notas = new int[5, 2];
            
            Random x = new Random();

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("\n");

                for(int j = 0; j < 2; j++)
                {
                    Notas[i, j] = x.Next(0, 31);

                    Console.Write($"{Notas[i, j],7}");
                }
            }

            Console.ReadKey();

            // Totalizar as notas de cada aluno

            Console.WriteLine("\n\n");

            int Soma;

            for(int i = 0; i < 5; i++)
            {
                Soma = 0;

                for(int j = 0; j < 2; j++)
                {
                    Soma += Notas[i, j];
                }

                Console.WriteLine($"Nota do Aluno {i + 1}: {Soma}");
            }

            Console.ReadKey();

            Console.WriteLine("");

            for (int i = 0; i < 2; i++)
            {
                Soma = 0;

                for (int j = 0; j < 5; j++)
                {
                    Soma += Notas[j, i];
                }

                Console.WriteLine($"Média da Prova {i+1}: {(double)Soma/5}");
            }

            Console.ReadKey();
        }

