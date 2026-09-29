using System;
using System.Collections.Generic;
using System.Text;

//Elemento:
//Pedido

//Tipo em C#:
//class
//Use para criar objetos diretamente sem obrigar herança.

//Papel na Arquitetura:
//Gerencia a coleção de itens (carrinho) e o total final

//Conceito de POO:
//Encapsulamento e Composição

namespace SiriCascudo
{
    //atua como agregador, a mesma List armazena objetos do tipo Lanche e Bebida
    internal class Pedido
    {
        public string NomeCliente { get; set; }

        public List<ItemCardapio> Itens { get; set; } = new List<ItemCardapio>();

        public void AdicionarItem(ItemCardapio item)
        {
            Itens.Add(item);

            Console.WriteLine($"\n {item.Descricao} adicionado ao pedido!");
        }


        public double CalcularTotalPedido()
        {
            double total = 0;

            foreach (var item in Itens)
            {
                total += item.CalcularPrecoFinal(); //POLIMORFISMO
            }

            return total;
        }


        public void ExibirResumo()
        {
            Console.WriteLine("----- CARRINHO DE COMPRAS -----");
            if (!string.IsNullOrEmpty(NomeCliente))
                Console.WriteLine($"Cliente: {NomeCliente}");


            if (Itens.Count == 0)
            {
                Console.WriteLine("Carrinho vazio.");
            }
            else
            {
                foreach(var item in Itens)
                    Console.WriteLine($"Nome: {item.Descricao} | Valor: R${item.CalcularPrecoFinal():F2}"); //:F2 é para mostrar duas casa após a vírgula
                Console.WriteLine($"\n Subtotal: R${CalcularTotalPedido():F2}");
            }


            Console.WriteLine("-------------------------");
        }
    }
}