static void Main(string[] args)
        {
            int LMO, CMO;
            int LMT, CMT;

            Console.Write("Número de Linhas da Matriz: ");
            LMO = int.Parse(Console.ReadLine());
            CMT = LMO;

            Console.Write("Número de Colunas da Matriz: ");
            CMO = int.Parse(Console.ReadLine());
            LMT = CMO;

            int[,] Matriz = new int[LMO, CMO];
            int[,] MatrizT = new int[LMT, CMT];

            Random x = new Random();

            for (int i = 0; i < LMO; i++)
            {
                Console.WriteLine("\n");

                for (int j = 0; j < CMO; j++)
                {
                    Matriz[i, j] = x.Next(1, 50);

                    Console.Write($"{Matriz[i, j],7}");
                }
            }

            Console.ReadKey();

            for (int i = 0; i < LMO; i++)
            {
                for (int j = 0; j < CMO; j++)
                {
                    MatrizT[j, i] = Matriz[i, j];
                }
            }

            //for (int i = 0; i < CMO; i++)
            //{
            //    for (int j = 0; j < LMO; j++)
            //    {
            //        MatrizT[i, j] = Matriz[j, i];
            //    }
            //}

            Console.WriteLine("\n\n");

            for (int i = 0; i < LMT; i++)
            {
                Console.WriteLine("\n");

                for (int j = 0; j < CMT; j++)
                {
                    Console.Write($"{MatrizT[i, j],7}");
                }
            }

            Console.ReadKey();
        }