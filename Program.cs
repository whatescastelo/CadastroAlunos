using System;

namespace CadastroAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while((opcaoUsuario != "X") || (opcaoUsuario != "x"))
            {
                switch(opcaoUsuario)
                {
                    case "1":

                        break;
                    case "2":

                        break;
                    case "3":

                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }

        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("DIGITE A OPÇÃO DESEJADA:");
            Console.WriteLine("1 - Inserir novo aluno.");
            Console.WriteLine("2 - Listar alunos.");
            Console.WriteLine("3 - Calcular média geral.");
            Console.WriteLine("X - Sair.");

            string opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;
        }
    }
}