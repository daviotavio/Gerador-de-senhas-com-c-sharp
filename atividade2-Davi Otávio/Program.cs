using System;

public class MyProgram2
{
    public static void Main(string[] args)
    {
        
        string nome;
        int idade;
        
        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine();

        Console.Write("Digite sua idade: ");
        idade = Convert.ToInt32(Console.ReadLine());
       
       if (idade >= 18 )
        {
        Console.WriteLine("Sugestão para senha: " +idade+nome);
        } 
        else 
        {
        Console.WriteLine("Digite sua idade: " +nome+idade);
        }

    }
}