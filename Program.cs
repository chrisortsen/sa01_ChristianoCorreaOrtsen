using System;
using System.Globalization;

namespace SA01_ChristianoCorreaOrtsen
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, nome2;
            double preco, preco2;
            int quantidade, quantidade2;

            Console.WriteLine("Sistema - Padaria Pão do Céu");
            Console.WriteLine();
            /* Cadastro de Vendas */
            Console.WriteLine("Cadastrar Venda");
            Console.WriteLine("Insira o nome do Produto: ");
            nome = Console.ReadLine();
            Console.WriteLine("Insira o valor do Produto: ");
            preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Insira o a quantidade de Produtos: ");
            quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Cadastrar Venda 2");
            Console.WriteLine("Insira o nome do Produto 2: ");
            nome2 = Console.ReadLine();
            Console.WriteLine("Insira o valor do Produto 2: ");
            preco2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Insira o a quantidade de Produtos 2: ");
            quantidade2 = int.Parse(Console.ReadLine());

            /* Menu */ 
            Console.WriteLine("Menu Principal");
            Console.WriteLine("Escolha o Submenu que voce deseja acessar e pressione a tecla ENTER: ");
            Console.WriteLine("1 - Cadastro de Vendas");
            Console.WriteLine("1 - Valor de vendas/estoque");
            Console.WriteLine("2 - Consultas");
            int menu = int.Parse(Console.ReadLine());

            if(menu == 1)
            {
                return;
            }

            else if (menu == 2)
            {
                /* Submenu de Vendas/Estoque */
                Console.WriteLine("Valor de vendas/estoque");
                Console.WriteLine("1 - Valor total das vendas (DIÁRIA)");
                Console.WriteLine("2 - Valor total das vendas (SEMANAL)");
                Console.WriteLine("3 - Quantidade de Produtos produzidos");
                Console.WriteLine("4 - Quantidade de Produtos em estoque");
                Console.WriteLine("5 - Retornar ao menu principal ");
                int menu2 = int.Parse(Console.ReadLine());

                if (menu2 == 1)
                {
                    Console.Write("Valor total das vendas (DIÁRIA): R$");
                    Console.WriteLine(preco * quantidade + preco2 * quantidade2);
                    Console.WriteLine();
                }
                else if (menu2 == 2)
                {
                    Console.Write("Valor total das vendas (DIÁRIA): R$");
                    Console.Write(preco * quantidade + preco2 * quantidade2);
                    Console.WriteLine();
                }
                else if (menu2 == 3)
                {
                    Console.Write("Quantidade de Produtos Produzidos: ");
                    Console.Write(quantidade + quantidade2);
                    Console.WriteLine();
                }
                else if (menu2 == 4)
                {
                    Console.Write("Quantidade de Produtos em Estoque: ");
                    Console.Write(quantidade + quantidade2);
                    Console.WriteLine();
                }
                else if (menu2 == 5)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Opção Inválida");
                }
            }

            else if (menu == 3)
            {
                /* Submenu de Consultas */
                Console.WriteLine("Menu de Consultas");
                Console.WriteLine("1 - Manter Clientes");
                Console.WriteLine("2 - Manter Vendas");
                Console.WriteLine("3 - Manter Produtos");
                Console.WriteLine("4 - Média de Vendas");
                Console.WriteLine("5 - Maior Venda");
                Console.WriteLine("6 - Menor Venda");
                Console.WriteLine("7 - Produto mais vendido");
                Console.WriteLine("8 - Produto menos vendido");
                Console.WriteLine("9 - Vendas por cliente");
                Console.WriteLine("10 - Vendas por produtos");
                Console.WriteLine("11 - Saldo Final");
                Console.WriteLine("12 - Retornar ao menu principal ");
                int menu3 = int.Parse(Console.ReadLine());

                if (menu3 == 1)
                {
                    Console.WriteLine("Cliente Mantido");
                    Console.WriteLine();
                }
                else if (menu3 == 2)
                {
                    Console.WriteLine("Venda Mantido");
                    Console.WriteLine();
                }
                else if (menu3 == 3)
                {
                    Console.WriteLine("Produto Mantido");
                    Console.WriteLine();
                }
                else if (menu3 == 4)
                {
                    Console.WriteLine("Media de Vendas: ");
                    Console.WriteLine(preco );
                }
                else if (menu3 == 5)
                {
                    if (preco * quantidade > preco2 * quantidade2)
                    {
                        Console.WriteLine("Maior Venda: " + nome);
                        Console.WriteLine("Valor: R$" + preco * quantidade);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Maior Venda: " + nome2);
                        Console.WriteLine("Valor: R$" + preco2 * quantidade2);
                        Console.WriteLine();
                    }
                }
                else if (menu3 == 6)
                {
                    if (preco * quantidade < preco2 * quantidade2)
                    {
                        Console.WriteLine("Menor Venda: " + nome);
                        Console.WriteLine("Valor: R$" + preco * quantidade);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Menor Venda: " + nome2);
                        Console.WriteLine("Valor: R$" + preco2 * quantidade2);
                        Console.WriteLine();
                    }
                }
                else if (menu3 == 7)
                {
                    if (quantidade > quantidade2)
                    {
                        Console.WriteLine("Produto mais vendido: "+ nome);
                        Console.WriteLine("Quantidade: " +quantidade);
                    }
                    else
                    {
                        Console.WriteLine("Produto mais vendido: " + nome2);
                        Console.WriteLine("Quantidade: " + quantidade2);
                    }

                }
                else if (menu3 == 8)
                {
                    if (quantidade < quantidade2)
                    {
                        Console.WriteLine("Produto menos vendido: " + nome);
                        Console.WriteLine("Quantidade: " + quantidade);
                    }
                    else
                    {
                        Console.WriteLine("Produto menos vendido: " + nome2);
                        Console.WriteLine("Quantidade: " + quantidade2);
                    }
                }
                else if (menu3 == 9)
                {
                    Console.WriteLine("Venda 1 : ");
                    Console.WriteLine("R$" + preco*quantidade);
                    Console.WriteLine();
                    Console.WriteLine("Venda 2 : ");
                    Console.WriteLine("R$" + preco2*quantidade2);
                    Console.WriteLine();
                }
                else if (menu3 == 10)
                {
                    Console.WriteLine("Produto : " +nome);
                    Console.WriteLine("R$" + preco * quantidade);
                    Console.WriteLine();
                    Console.WriteLine("Produto : "+nome2);
                    Console.WriteLine("R$" + preco2 * quantidade2);
                    Console.WriteLine();
                }
                else if (menu3 == 11)
                {
                    Console.WriteLine("Saldo Final: ");
                    Console.Write("R$ ");
                    Console.Write(preco * quantidade + preco2 * quantidade2);
                    Console.WriteLine();
                }
                else if (menu3 == 12)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Opção Inválida");
                }
            }
            else
            {
                Console.WriteLine("Opção Inválida");
            }
        }
    }
}
