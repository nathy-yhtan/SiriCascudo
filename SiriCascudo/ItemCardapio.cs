using SiriCascudo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

//Elemento:
//ItemCardapio

//Tipo em C#:
//abstract class
//Use para garantir que todas as subclasses tenham certos métodos implementados, mas também fornecer implementações padrão para outros.

//Papel na Arquitetura:
//Classe base com propriedades comuns (Código, Descrição, Preço)

//Conceito de POO:
//Herança e Abstração

namespace SiriCascudo
{
    // A classe abstrata herda da interface ICalcularPrecoFinal
    public abstract class ItemCardapio : ICalcularPrecoFinal //":" -> HERANÇA
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public double PrecoBase { get; set; }

        //CONSTRUTOR:
        //Inicializa as PROPRIEDADES do item
        public ItemCardapio(int codigo, string descricao, double precoBase)
        {
            Codigo = codigo;
            Descricao = descricao;
            PrecoBase = precoBase;
        }

        // MÉTODO ABSTRATO:
        // Deve ser implementado (sobrescrito) (ISSO É POLIMORFISMO) pelas classes filhas
        public abstract double CalcularPrecoFinal();
    }
}