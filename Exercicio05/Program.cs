using System;

class Program
{
    static void Main(string[] args)
    {
        Ingresso show = new Ingresso();

        show.SetNomeDoShow("Show do Avenged Sevenfold");
        show.SetPreco(490.00);
        show.SetQuantidadeDisponivel(15000);

        Console.WriteLine("--- DADOS INICIAIS (VIA GETTERS) ---");
        Console.WriteLine($"Nome: {show.GetNomeDoShow()}");
        Console.WriteLine($"Preço: R$ {show.GetPreco():F2}");
        Console.WriteLine($"Quantidade: {show.GetQuantidadeDisponivel()}");

        show.SetPreco(650.00);
        show.SetQuantidadeDisponivel(10000);

        Console.WriteLine("\n--- DADOS ATUALIZADOS (VIA MÉTODO) ---");
        show.ExibirInformacoes();

        Console.WriteLine("\nPressione ENTER para sair...");
        Console.ReadLine();
    }
}