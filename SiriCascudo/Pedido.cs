using System;
using System.Collections.Generic;

public class Pedido
{
    // Uso de Coleções (List)
    private List<ItemCardapio> itens = new List<ItemCardapio>();

    public void AdicionarItem(ItemCardapio item)
    {
        itens.Add(item);
        Console.WriteLine($"--> {item.Descricao} adicionado ao pedido!");
    }

    public decimal CalcularTotalPedido()
    {
        decimal total = 0;
        foreach (var item in itens)
        {
            total += item.CalcularPrecoFinal(); // Polimorfismo em ação!
        }
        return total;
    }

    public void ExibirResumoPedido()
    {
        Console.WriteLine("\n--- RESUMO DO PEDIDO ---");
        foreach (var item in itens)
        {
            item.ExibirDetalhes();
        }
        Console.WriteLine($"\nTOTAL DO PEDIDO: R$ {CalcularTotalPedido():F2}");
    }
}