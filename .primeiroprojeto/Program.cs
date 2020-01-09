using System;

namespace _primeiroprojeto
{
    class Program
    {
        static void Main(string[] args)
        {

            string opc;

            do
            {
                opc = ObterOpc();

                switch (opc)
                {
                    case "1":
                        //Adicionar aluno
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