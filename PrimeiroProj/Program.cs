using System;
using PrimeiroProj;

namespace _primeiroprojeto
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("\nDigite a quantidade de alunos: ");
            int quant = int.Parse(Console.ReadLine());

            while (quant <= 0)
            {
                Console.Write("Digite uma quantidade válida de alunos (maior que zero): ");
                quant = int.Parse(Console.ReadLine());
            }

            bool dec = true;
            Aluno[] alunos = new Aluno[quant];
            int indice = 0;
            string opc;

            do
            {
                opc = ObterOpc();

                switch (opc)
                {
                    case "1":   //Adicionar aluno
                        Console.Write("\nInforme o nome do aluno: ");
                        var aluno = new Aluno();
                        aluno.nome = Console.ReadLine();
                        Console.Write("Informe a nota do aluno: ");
                        decimal nota;
                        while ((dec = !decimal.TryParse(Console.ReadLine(), out nota)) || ((nota < 0) || (nota > 10)))
                        {
                            if (dec)
                                Console.Write("A nota do aluno deve ser decimal! Digite novamente: ");
                            else
                                Console.Write("A nota deve estar entre 0 e 10! Digite novamente: ");
                        }
                        aluno.nota = nota;
                        alunos[indice] = aluno;
                        indice++;

                        break;
                    case "2":
                        //Listar alunos
                        for (int i = 0; i < indice; i++)
                        {
                            Console.WriteLine($"\n\t\tAluno {i+1} \nNome do aluno: {alunos[i].nome} \nNota do aluno: {alunos[i].nota}");
                        }
                        break;
                    case "3":
                        //Calcular média geral
                        break;
                    case "0":
                        Console.WriteLine("\n\t\tAté a próxima!\n");
                        break;
                }
            } while (opc != "0");

        }

        private static string ObterOpc ()
        {
            string opc;
            Console.Write("\n\t\tMenu de opções: \n\n1- Inserir novo aluno \n2- Listar alunos \n3- Calcular média geral \n\n0- Sair \n\nOpção desejada: ");
            opc = Console.ReadLine();
            if ((opc != "1") && (opc != "2") && (opc != "3") && (opc != "0"))
                opc = Validacao(opc);
            return opc;
        }
        
        private static string Validacao (string opc)
        {
            Console.WriteLine();
            while ((opc != "1") && (opc != "2") && (opc != "3") && (opc != "0"))
            {
                Console.Write("Opção inválida! Digite novamente: ");
                opc = Console.ReadLine();
                if ((opc == "1") || (opc == "2") || (opc == "3"))
                    continue;
                else if (opc == "0")
                    Console.WriteLine("\n\t\tAté a próxima!\n");
            }
            return opc;
        }
    
    }
}