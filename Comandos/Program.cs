using System;
using Comandos.ok;

namespace Comandos
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new a();

            a.funcao("qualquer coisa");

            Console.WriteLine("\n\t\tPrograma inicializado com suacesso!"); //Output

            int vezes = 5, x; //Criação de variáveis

            // Mensagem de erro -> throw new InvalidOperationException("Digite sua mensagem aqui"); <- Interrompe o programa
            Console.WriteLine("\nDigite um número entre 1 a 100");
            x = int.Parse(Console.ReadLine());

            while(x < 1 || x > 100)
            {
                Console.WriteLine("\nDigite um número válido! ");
                x = int.Parse(Console.ReadLine());
            }

            for (int i = x  ; i > 0; i--) //Loop for
            {
                Console.WriteLine($"X atualmente tem valor igual a {i}"); //$ antes das aspas em c# = f antes das aspas em python
            }

        }
    }
}
