class Matricula
{
    public string NomeDoAluno { get; set; }
    public string Curso { get; set; }
    public int NumeroMatricula { get; set; }
    public string Situacao { get; set; }
    public string DataInicial { get; set; }

    public Matricula(string nome, string curso, int numeroMatricula, string dataInicial)
    {
        NomeDoAluno = nome;
        Curso = curso;
        NumeroMatricula = numeroMatricula;
        DataInicial = dataInicial;
        Situacao = "Ativa";
    }

    public void Trancar() => Situacao = "Trancada";
    public void Reativar() => Situacao = "Ativa";

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Aluno: {NomeDoAluno}");
        Console.WriteLine($"Curso: {Curso}");
        Console.WriteLine($"Nº Matrícula: {NumeroMatricula}");
        Console.WriteLine($"Situação: {Situacao}");
        Console.WriteLine($"Data Inicial: {DataInicial}\n");
    }
}