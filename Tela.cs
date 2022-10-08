using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDoValdecio
{
    public class Tela
    {
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("|------------------------------------|");
            Console.WriteLine("|          MENU PRINCIPAL            |");
            Console.WriteLine("|------------------------------------|");
            Console.WriteLine("|1 -      Cadastrar Produtos         |");
            Console.WriteLine("|2 -      Lista de Produtos          |");
            Console.WriteLine("|3 -            Sair                 |");
            Console.WriteLine("|------------------------------------|");
        }
        public static Produto NovoProduto()
        {
            Produto p = new Produto();
            Console.Clear();
            Console.WriteLine("|------------------------------------|");
            Console.WriteLine("|          ADICIONAR PRODUTO         |");
            Console.WriteLine("|------------------------------------|");


            Console.Write("Informe o código do produto:");
            p.Codigo = int.Parse(System.Console.ReadLine());
            Console.Write("Informe o nome do produto:");
            p.Nome = System.Console.ReadLine();
            Console.Write("Informe o custo do produto:");
            p.Custo = double.Parse(System.Console.ReadLine());
            Console.Write("Informe a venda do produto:");
            p.Venda = double.Parse(System.Console.ReadLine());
            return p;
        }
        public static void MostrarProdutos(Produto p)
        {
            Console.Clear();
            Console.WriteLine("|-------------------------------------------------------------|");
            Console.WriteLine("|                      LISTA DE PRODUTOS                      |");
            Console.WriteLine("|-------------------------------------------------------------|");
            Console.WriteLine("| COD. Prod   |   Descrição Produto   |  Custo     |   Venda  |");
            Console.WriteLine("|" + p.Codigo + " | " + p.Nome + " | " + p.Custo + " | " + p.Venda + " | ");
            Console.WriteLine("|-------------------------------------------------------------|");
        }
    }
}