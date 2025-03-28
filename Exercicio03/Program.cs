using System;

class Program
{
    static void Main(string[] args)
    {
        Ingresso show = new Ingresso();
        show.nomeDoShow = "Show do Avenged Sevenfold";
        show.preco = 490.00;
        show.quantidadeDisponivel = 15000;

        Console.WriteLine("--- Dados Iniciais ---");
        show.ExibirInformacoes();

        show.AlterarPreco(650.00);
        show.AlterarQuantidade(10000);

        Console.WriteLine("\n--- Dados Atualizados ---");
        show.ExibirInformacoes();

        Console.WriteLine("\nPressione ENTER para sair...");
        Console.ReadLine();
    }
}