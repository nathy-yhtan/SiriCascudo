using System;
using System.Collections.Generic;
using System.Text;

//Elemento:
//Bebida

//Tipo em C#:
//class (filha)
//Use para criar objetos diretamente sem (não é esse caso) obrigar herança.

//Papel na Arquitetura:
//Especialização para bebidas com preços por tamanho(300ml, 500ml, 1L)

//Conceito de POO:
//Herança e Polimorfismo

namespace SiriCascudo
{
    //OBJETO
    public class Bebida : ItemCardapio
        {
        //Característica própria
        public string Tamanho { get; set; } // "300ml", "500ml" ou "1L"

        public Bebida(int codigo, string descricao, double precoBase, string tamanho)
            : base (codigo, descricao, precoBase)
        {
            Tamanho = tamanho;
        }

        // Sobrescreve (override) o cálculo aplicando taxas dependendo do tamanho
        public override double CalcularPrecoFinal()
        {
            if (Tamanho == "500ml") return PrecoBase + 2.00;
            if (Tamanho == "1L") return PrecoBase + 4.00;
            return PrecoBase; //300ml
        }
    }
}