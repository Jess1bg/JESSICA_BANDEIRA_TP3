using System;

class Program
{
    static void Main(string[] args)
    {
        Ingresso show = new Ingresso(
            "Show do Avenged Sevenfold",
            650.00,
            8000
        );

        Console.WriteLine("--- TESTANDO GETTERS ---");
        Console.WriteLine($"Nome: {show.GetNomeDoShow()}");
        Console.WriteLine($"Preço: {show.GetPreco():C2}");
        Console.WriteLine($"Quantidade: {show.GetQuantidadeDisponivel()}");

        show.SetPreco(700.00);
        show.SetQuantidadeDisponivel(7500);

        show.AlterarPreco(750.00);
        show.AlterarQuantidade(7000);

        Console.WriteLine("\n--- DADOS FINAIS ---");
        show.ExibirInformacoes();

        Console.WriteLine("\nPressione ENTER para sair...");
        Console.ReadLine();
    }
}