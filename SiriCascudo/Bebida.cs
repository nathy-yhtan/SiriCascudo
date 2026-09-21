using System;

public class Bebida : ItemCardapio
{
    public string Tamanho { get; private set; } = "300ml";

    public Bebida(int codigo, string descricao, decimal precoBase)
        : base(codigo, descricao, precoBase)
    {
    }

    public void DefinirTamanho(int opcaoTamanho)
    {
        switch (opcaoTamanho)
        {
            case 1:
                Tamanho = "300ml";
                break;
            case 2:
                Tamanho = "500ml";
                break;
            case 3:
                Tamanho = "1L";
                break;
            default:
                throw new ArgumentException("Opção de tamanho inválida!");
        }
    }

    // Polimorfismo: Preço ajustado de acordo com o tamanho selecionado
    public override decimal CalcularPrecoFinal()
    {
        if (Tamanho == "500ml") return PrecoBase + 2.00m;
        if (Tamanho == "1L") return PrecoBase + 5.00m;
        return PrecoBase; // 300ml
    }

    public override void ExibirDetalhes()
    {
        Console.WriteLine($"[Bebida {Codigo}] {Descricao} ({Tamanho}) - Preço Final: R$ {CalcularPrecoFinal():F2}");
    }
}