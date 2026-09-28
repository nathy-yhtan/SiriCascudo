using System;
using System.Collections.Generic;
using System.Text;

//Elemento:
//Lanche

//Tipo em C#:
//class (filha)
//Use para criar objetos diretamente sem (não é esse caso) obrigar herança.

//Papel na Arquitetura:
//Especialização para comida com lista de ingredientes extras

//Conceito de POO:
//Herança e Polimorfismo

namespace SiriCascudo
{
    //OBJETO
    //Como caracterizamos as class são exemplo de ENCAPSULAMENTO
    public class Lanche : ItemCardapio
    {
        //Lista de ingredientes extras escolhidos pelo cliente
        //get set também é exemplo de ENCAPSULAMENTO
        //List<> é um exemplo de coleção, é dinâmica que permite adicionar ou remover elementos
        public List<string> IngredientesExtras { get; set; } = new List<string>();

        // Construtor repassa os dados base para o pai através da palavra-chave 'base'
        public Lanche(int codigo, string descricao, double precoBase)
            : base(codigo, descricao, precoBase) { }

        // Sobrescreve (override) o cálculo somando R$ 2,00 por ingrediente extra
        public override double CalcularPrecoFinal()
        {
            double total = PrecoBase;
            total += IngredientesExtras.Count * 2.00;
            return total;
        }
    }
}