using System;

public abstract class ItemCardapio : IImprimivel
{
    // Encapsulamento + Propriedades Auto-implementadas
    public int Codigo { get; private set; }
    public string Descricao { get; private set; }

    private decimal precoBase;
    public decimal PrecoBase
    {
        get { return precoBase; }
        private set
        {
            if (value < 0)
                throw new ArgumentException("O preço base não pode ser negativo."); // Tratamento de Exceção
            precoBase = value;
        }
    }

    // Construtor
    public ItemCardapio(int codigo, string descricao, decimal precoBase)
    {
        Codigo = codigo;
        Descricao = descricao;
        PrecoBase = precoBase;
    }

    // Método virtual para permitir Polimorfismo
    public virtual decimal CalcularPrecoFinal()
    {
        return PrecoBase;
    }

    public abstract void ExibirDetalhes();
}