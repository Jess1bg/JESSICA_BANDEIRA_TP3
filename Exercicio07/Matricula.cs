using System;

class Matricula
{
    public string NomeDoAluno { get; set; }
    public string Curso { get; set; }
    public int NumeroMatricula { get; set; }
    public string Situacao { get; set; }
    public string DataInicial { get; set; }

    public Matricula()
    {
        Situacao = "Ativa";
    }

    public Matricula(string nome, string curso, int numeroMatricula, string dataInicial)
    {
        NomeDoAluno = nome;
        Curso = curso;
        NumeroMatricula = numeroMatricula;
        DataInicial = dataInicial;
        Situacao = "Ativa"; 
    }
}




