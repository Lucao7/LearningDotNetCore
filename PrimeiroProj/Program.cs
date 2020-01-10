using System;
using PrimeiroProj;

namespace _primeiroprojeto
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool dec = true;
            Aluno[] alunos = new Aluno[5];
            string opc;

            do
            {
                opc = ObterOpc();

                switch (opc)
                {
                    case "1":
                        //Adicionar aluno
                        Console.Write("\nInforme o nome do aluno: ");
                        Aluno aluno = new Aluno();
                        aluno.nome = Console.ReadLine();

                        Console.Write("Informe a nota do aluno: ");

                        while ((dec = !decimal.TryParse(Console.ReadLine(), out decimal nota)) || ((nota < 0) || (nota > 10)))
                        {
                            if (dec)
                                Console.Write("A nota do aluno deve ser decimal! Digite novamente: ");
                            else
                                Console.Write("A nota deve estar entre 0 e 10! Digite novamente: ");
                        }
                        break;
                    case "2":
                        //Listar alunos
                        break;
                    case "3":
                        //Calcular média geral
                        break;
                    case "0":
                        Console.WriteLine("\n\t\tAté a próxima!\n");
                        break;
                    default:
                        opc = Validacao(opc);
                        break;
                }
            } while (opc != "0");

        }

        private static string ObterOpc ()
        {
            string opc;
            Console.Write("\n\t\tMenu de opções: \n\n1- Inserir novo aluno \n2- Listar alunos \n3- Calcular média geral \n\n0- Sair \n\nOpção desejada: ");
            opc = Console.ReadLine();
            return opc;
        }
        
        private static string Validacao (string opc)
        {
            Console.WriteLine();
            while ((opc != "1") && (opc != "2") && (opc != "3") && (opc != "0"))
            {
                Console.Write("Opção inválida! Digite novamente: ");
                opc = Console.ReadLine();
                if (opc == "0")
                    Console.WriteLine("\n\t\tAté a próxima!\n");
            }
            return opc;
        }
    
    }
}