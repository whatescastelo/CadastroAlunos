using System;

namespace CadastroAlunos{
    class Program{
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            

            opcaoUsuario = Console.ReadLine();

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