﻿using System;

namespace Revisao{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("DIGITE A OPÇÃO DESEJADA:");
            Console.WriteLine("1 - Inserir novo aluno.");
            Console.WriteLine("2 - Listar alunos.");
            Console.WriteLine("3 - Calcular média geral.");
            Console.WriteLine("X - Sair.");
        }

        string opcaoUsuario = Console.ReadLine(); 
    }
}