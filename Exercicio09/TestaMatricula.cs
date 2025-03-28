using System;

class TestaMatricula
{
    static void Main()
    {
        Matricula aluno = new Matricula(
            "Fernando Garcia",
            "Arquiteto",
            20490040,
            "03/05/2024"
        );

        Console.WriteLine("=== SITUAÇÃO INICIAL ===");
        aluno.ExibirInformacoes();

        aluno.Trancar();
        Console.WriteLine("=== APÓS TRANSCAR ===");
        aluno.ExibirInformacoes();

        aluno.Reativar();
        Console.WriteLine("=== APÓS REATIVAR ===");
        aluno.ExibirInformacoes();

        Console.WriteLine("Pressione ENTER para encerrar...");
        Console.ReadLine();
    }
}