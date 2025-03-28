using System;

class Program
{
    static void Main(string[] args)
    {
        Matricula aluno1 = new Matricula(
            "Patricia Junqueira",
            "Engenharia de Petroleo",
            2036007,
            "20/03/2022"
        );

        Console.WriteLine("--- MATRÍCULA CRIADA ---");
        aluno1.ExibirInformacoes();

        aluno1.Trancar();
        Console.WriteLine("\n--- APÓS TRANCAR ---");
        aluno1.ExibirInformacoes();

        aluno1.Reativar();
        Console.WriteLine("\n--- APÓS REATIVAR ---");
        aluno1.ExibirInformacoes();

        Console.WriteLine("\nPressione ENTER para sair...");
        Console.ReadLine();
    }
}