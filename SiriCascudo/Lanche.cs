using System;
using System.Collections.Generic;

public class Lanche : ItemCardapio
{
    // Coleção/Lista de ingredientes
    public List<string> IngredientesExtras { get; private set; }
    private const decimal PRECO_INGREDIENTE_EXTRA = 2.50m;

    // Construtor usando base()
    public Lanche(int codigo, string descricao, decimal precoBase)
        : base(codigo, descricao, precoBase)
    {
        IngredientesExtras = new List<string>();
    }

    public void AdicionarIngrediente(string ingrediente)
    {
        IngredientesExtras.Add(ingrediente);
    }

    // Polimorfismo: sobrescrevendo o método CalcularPrecoFinal
    public override decimal CalcularPrecoFinal()
    {
        return PrecoBase + (IngredientesExtras.Count * PRECO_INGREDIENTE_EXTRA);
    }

    // Polimorfismo / Interface
    public override void ExibirDetalhes()
    {
        Console.WriteLine($"[Lanche {Codigo}] {Descricao} - Preço Base: R$ {PrecoBase:F2}");
        if (IngredientesExtras.Count > 0)
        {
            Console.WriteLine($"   Extras adicionados: {string.Join(", ", IngredientesExtras)}");
        }
        Console.WriteLine($"   Preço Total: R$ {CalcularPrecoFinal():F2}");
    }
}