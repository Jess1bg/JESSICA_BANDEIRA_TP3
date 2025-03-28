using System;

class Program
{
    static void Main(string[] args)
    {
        Matricula aluno1 = new Matricula(
            "Jéssica Bandeira",
            "Analise e Desenvolvimento de Sistemas",
            20240001,
            "29/02/2023"
        );

        aluno1.Situacao = "Ativa";

        Console.WriteLine("--- DADOS DA MATRÍCULA ---");
        Console.WriteLine($"Aluno: {aluno1.NomeDoAluno}");
        Console.WriteLine($"Curso: {aluno1.Curso}");
        Console.WriteLine($"Nº Matrícula: {aluno1.NumeroMatricula}");
        Console.WriteLine($"Situação: {aluno1.Situacao}");
        Console.WriteLine($"Data Inicial: {aluno1.DataInicial}");

        Console.WriteLine("\nPressione ENTER para sair...");
        Console.ReadLine();
    }
}