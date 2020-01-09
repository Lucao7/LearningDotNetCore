using System;

namespace instrucoes.teste
{
    public class teste
    {
        public void Declaracoes()
            {
                int a;
                int b = 2, c = 3;
                const int d = 4;
                a = 1;
                Console.WriteLine(a + b + c + d);
            }

            public void InstrucaoIf(string[] args)
            {
                if (args.Length == 0)
                {
                    Console.WriteLine("Nenhum argumento");
                }
                else if (args.Length == 1)
                {
                    Console.WriteLine("Um argumento");
                }
                else
                {
                    Console.WriteLine($"{args.Length} argumentos");
                }
            }

            public void InstrucaoSwitch(string[] args)
            {
                int nArgumentos = args.Length;
                switch (nArgumentos)
                {
                    case 0:
                        Console.WriteLine("Nenhum Argumento");
                        break;
                    case 1:
                        Console.WriteLine("Um Argumento");
                        break;
                    case 2:
                        Console.WriteLine($"{nArgumentos} Argumentos");
                        break;
                }
            }

            public void InstrucaoWhile(string[] args)
            {
                int i = 0;
                while (i < args.Length)
                {
                    Console.WriteLine(args[i]);
                    i++;
                }
            }

            public void InstrucaoDo(string[] args)
            {
                string texto;
                do
                {
                    texto = Console.ReadLine();
                    Console.WriteLine("Você digitou", texto);
                } while (!string.IsNullOrEmpty(texto));
            }

            public void InstrucaoFor(string[] args)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine(args[i]);
                }
            }

            public void InstrucaoForeach(string[] args)
            {
                foreach (string s in args)
                {
                    Console.WriteLine(s);
                }
            }

            public void InstrucaoBreak(string[] args)
            {
                while (true)
                {
                    string s = Console.ReadLine();

                    if (string.IsNullOrEmpty(s))
                        break;

                    Console.WriteLine("Você digitou " + s);
                }
            }

            public void InstrucaoContinue(string[] args)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    if (args[i].StartsWith("/"))
                        continue;

                    Console.WriteLine($"{i+1}º vez: ", args[i]);
                }
            }

            public void InstrucaoReturn(string[] args)
            {
                int Somar(int a, int b)
                {
                    return a + b;
                }

                Console.WriteLine(Somar(1, 2));
                Console.WriteLine(Somar(3, 4));
                Console.WriteLine(Somar(5, 6));
                return;
            }

            public void InstrucaoTryCatchFinallyThrow(string[] args)
            {
                double Dividir(double x, double y)
                {
                    if (y == 0)
                        throw new DivideByZeroException();

                    return x / y;
                }

                try
                {
                    if (args.Length != 2)
                        throw new InvalidOperationException("Informe 2 números");

                    double x = double.Parse(args[0]);
                    double y = double.Parse(args[1]);
                    Console.WriteLine(Dividir(x, y));
                }

                catch (InvalidOperationException e)
                {
                    Console.WriteLine($"Erro genérico: {e.Message}");
                }

                finally
                {
                    Console.WriteLine("Deu certo! Até logo!");
                }
            }

            public void InstrucaoUsing(string[] args)
            {
                using (System.IO.TextWriter w = System.IO.File.CreateText("teste.txt"))
                {
                    w.WriteLine("Line 1");
                    w.WriteLine("Line 2");
                    w.WriteLine("Line 3");

                    //Descarte destas variáveis após a execução deste bloco
                }
            }
    }
}