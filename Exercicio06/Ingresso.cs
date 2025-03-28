class Ingresso
{
    public string nomeDoShow;
    public double preco;
    public int quantidadeDisponivel;

    public Ingresso(string nome, double valor, int quantidade)
    {
        nomeDoShow = nome;
        preco = valor;
        quantidadeDisponivel = quantidade;
    }

    public string GetNomeDoShow() => nomeDoShow;
    public double GetPreco() => preco;
    public int GetQuantidadeDisponivel() => quantidadeDisponivel;

    public void SetNomeDoShow(string novoNome) => nomeDoShow = novoNome;
    public void SetPreco(double novoPreco) => preco = novoPreco;
    public void SetQuantidadeDisponivel(int novaQtd) => quantidadeDisponivel = novaQtd;

    public void AlterarPreco(double novoPreco) => preco = novoPreco;
    public void AlterarQuantidade(int novaQuantidade) => quantidadeDisponivel = novaQuantidade;

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome do Show: {nomeDoShow}");
        Console.WriteLine($"Preço: R$ {preco:F2}");
        Console.WriteLine($"Quantidade Disponível: {quantidadeDisponivel}");
    }
}