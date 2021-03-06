using System;

namespace CadastroAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            int indiceAluno = 0;
            string opcaoUsuario = ObterOpcaoUsuario();

            while((opcaoUsuario != "X") || (opcaoUsuario != "x"))
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("\nNOME DO ALUNO: ");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("NOTA DO ALUNO: ");
                        
                        if(decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }else
                        {
                            throw new ArgumentException("O valor da nota deve ser decimal.");
                        }

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;

                        break;
                    case "2":
                     
                        foreach(var a in alunos)
                        {
                            if(!string.IsNullOrEmpty(a.Nome))
                            {
                                Console.WriteLine($"ALUNO: {a.Nome}\nNOTA: {a.Nota}\n");
                                
                            }
                            
                        }
                        break;
                    case "3":
                        decimal notaTotal = 0;
                        int n = 0;
                        foreach(var a in alunos)
                        {
                            if(!string.IsNullOrEmpty(a.Nome))
                            {
                                notaTotal = notaTotal + a.Nota;
                                n++;
                            }
                            
                        }
                        var media = notaTotal / n;
                        Console.WriteLine($"MÉDIA GERAL: {media}\n");

                        Conceito conceitoGeral;

                        if(media < 3)
                        {
                            conceitoGeral = Conceito.E;
                        }else if (media < 6)
                        {
                            conceitoGeral = Conceito.D;
                        }else if (media < 7)
                        {
                            conceitoGeral = Conceito.C;
                        }else if (media < 8)
                        {
                            conceitoGeral = Conceito.B;
                        }else if (media < 9)
                        {
                            conceitoGeral = Conceito.A;
                        }

                        Console.WriteLine($"Conceito: {conceitoGeral}");
                        
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }

        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("\nDIGITE A OPÇÃO DESEJADA:");
            Console.WriteLine("1 - Inserir novo aluno.");
            Console.WriteLine("2 - Listar alunos.");
            Console.WriteLine("3 - Calcular média geral.");
            Console.WriteLine("X - Sair.");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}