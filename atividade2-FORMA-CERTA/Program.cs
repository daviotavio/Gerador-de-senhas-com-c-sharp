using System;

namespace atividade2_FORMA_CERTA
{
    class Program
    {
        static void Main(string[] args)
        {

            string nome;
            int idade, anoNascimento;

            Console.WriteLine("Bem vindo ao gerador de senhas, para começar, informe seu nome por gentileza: ");
            nome = Console.ReadLine();

            Console.WriteLine("Agora nos informe o ano do seu nascimento: ");
            anoNascimento = int.Parse(Console.ReadLine());
            idade = DateTime.Now.Year - anoNascimento;

            if (idade >= 18)
            {
                Console.WriteLine("Sua senha super secreta é: " + idade + nome);
            } 
            else
            {
                Console.WriteLine("Sua senha super secreta é: " + nome + idade);
            }

            
        }
    }
}
