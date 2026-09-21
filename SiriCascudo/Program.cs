using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[] ingredientesDisponiveis = { "Queijo Extra", "Bacon", "Ovo", "Salada Extra", "Molho Especial" };

        List<Lanche> cardapioLanches = new List<Lanche>
        {
            new Lanche(1, "X-Burguer", 15.00m),
            new Lanche(2, "X-Salada", 18.00m),
            new Lanche(3, "X-Bacon", 22.00m),
            new Lanche(4, "X-Tudo", 28.00m)
        };

        // As bebidas no cardápio agora têm apenas o preço base (300ml)
        List<Bebida> cardapioBebidas = new List<Bebida>
        {
            new Bebida(10, "Refrigerante", 6.00m),
            new Bebida(11, "Suco Natural", 8.00m),
            new Bebida(12, "Água Mineral", 4.00m)
        };

        Pedido meuPedido = new Pedido();
        bool executando = true;

        Console.WriteLine("\t=== BEM-VINDO À LANCHONETE ===");

        while (executando)
        {
            try
            {
                Console.WriteLine("\nMenu Principal:");
                Console.WriteLine("1 - Escolher Lanche do Cardápio");
                Console.WriteLine("2 - Escolher Bebida do Cardápio");
                Console.WriteLine("3 - Finalizar Pedido");
                Console.Write("Opção: ");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("\n--- CARDÁPIO DE LANCHES ---");
                        for (int i = 0; i < cardapioLanches.Count; i++)
                        {
                            Console.WriteLine($"{i + 1} - {cardapioLanches[i].Descricao} (R$ {cardapioLanches[i].PrecoBase:F2})");
                        }

                        Console.Write("Escolha o número do lanche desejado: ");
                        int opcaoLanche = int.Parse(Console.ReadLine());

                        if (opcaoLanche >= 1 && opcaoLanche <= cardapioLanches.Count)
                        {
                            Lanche lancheModelo = cardapioLanches[opcaoLanche - 1];
                            Lanche lancheEscolhido = new Lanche(lancheModelo.Codigo, lancheModelo.Descricao, lancheModelo.PrecoBase);

                            Console.WriteLine("\n--- Ingredientes Extras (R$ 2,50 cada) ---");
                            for (int i = 0; i < ingredientesDisponiveis.Length; i++)
                            {
                                Console.WriteLine($"{i + 1} - {ingredientesDisponiveis[i]}");
                            }

                            Console.WriteLine("Digite o número do ingrediente (ou 0 para concluir os extras):");
                            while (true)
                            {
                                Console.Write("Adicionar extra: ");
                                int numIngrediente = int.Parse(Console.ReadLine());

                                if (numIngrediente == 0) break;

                                if (numIngrediente > 0 && numIngrediente <= ingredientesDisponiveis.Length)
                                {
                                    string ingrediente = ingredientesDisponiveis[numIngrediente - 1];
                                    lancheEscolhido.AdicionarIngrediente(ingrediente);
                                    Console.WriteLine($"-> {ingrediente} adicionado!");
                                }
                                else
                                {
                                    Console.WriteLine("Ingrediente inválido!");
                                }
                            }

                            meuPedido.AdicionarItem(lancheEscolhido);
                        }
                        else
                        {
                            Console.WriteLine("Opção de lanche inválida!");
                        }
                        break;

                    case 2:
                        Console.WriteLine("\n--- CARDÁPIO DE BEBIDAS ---");
                        for (int i = 0; i < cardapioBebidas.Count; i++)
                        {
                            Console.WriteLine($"{i + 1} - {cardapioBebidas[i].Descricao} (Preço Base: R$ {cardapioBebidas[i].PrecoBase:F2})");
                        }

                        Console.Write("Escolha a bebida desejada: ");
                        int opcaoBebida = int.Parse(Console.ReadLine());

                        if (opcaoBebida >= 1 && opcaoBebida <= cardapioBebidas.Count)
                        {
                            Bebida bebidaModelo = cardapioBebidas[opcaoBebida - 1];
                            Bebida bebidaEscolhida = new Bebida(bebidaModelo.Codigo, bebidaModelo.Descricao, bebidaModelo.PrecoBase);

                            // Escolha do Tamanho
                            Console.WriteLine("\n--- ESCOLHA O TAMANHO ---");
                            Console.WriteLine("1 - 300ml (Preço Base)");
                            Console.WriteLine("2 - 500ml (+ R$ 2,00)");
                            Console.WriteLine("3 - 1L    (+ R$ 5,00)");
                            Console.Write("Opção de tamanho: ");

                            int opcTamanho = int.Parse(Console.ReadLine());
                            bebidaEscolhida.DefinirTamanho(opcTamanho);

                            meuPedido.AdicionarItem(bebidaEscolhida);
                        }
                        else
                        {
                            Console.WriteLine("Opção de bebida inválida!");
                        }
                        break;

                    case 3:
                        executando = false;
                        meuPedido.ExibirResumoPedido();
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\n[ERRO] Digite apenas números válidos!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n[ERRO]: {ex.Message}");
            }
        }
    }
}