using SiriCascudo;
using System;
using System.Collections.Generic;

//Elemento:
//Program

//Tipo em C#:
//class (Main)

//Papel na Arquitetura:
//Menu interativo no console, leitura de dados e controle de tela

//Conceito de POO:
//Interface do Usuário e Exceções

class Program
{
    static void Main(string[] args)
    {


        bool executando = true;


        Console.WriteLine("=-=-= BEM VINDO AO SIRI CASCUDO =-=-=");
        Console.WriteLine("=-= ONDE HAMBURGUERIAS ACONTECEM =-=");


        while (executando)
        {
            Console.WriteLine("--- Selecione o que deseja ---");
            Console.WriteLine("1. Hamburguer (R$ 10,00)");
            Console.WriteLine("2. Batatas fritas (R$ 5,00)");
            Console.WriteLine("3. Refrigerante (Preços variam)");
            Console.WriteLine("4. Ver carrinho");
            Console.WriteLine("5. Efetuar pagamento");
            Console.WriteLine("0. Sair");


            string opcao = Console.ReadLine()!;


            switch (opcao)
            {
                case "1":
                    Lanche hamburguer = new Lanche(001, "Hamburguer", 10.00);

                    Console.WriteLine("Você selecionou o hamburguer.");
                    Console.WriteLine("");


                    Console.WriteLine("");
                    break;
            }







        }


    }
}