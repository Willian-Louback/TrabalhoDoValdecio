using System;

namespace TrabalhoDoValdecio
{
    public class Program
    {
        static void Main(string[] args)
        {
            int escolha = 0;
            Produtos meuproduto = new Produtos();
            while (escolha != 3)
            {
                switch (escolha)
                {
                    case 0:
                        Tela.Menu();
                        escolha = int.Parse(System.Console.ReadLine());
                        break;
                    case 1:
                        Produto p = Tela.NovoProduto();
                        meuproduto.AdicionarProduto(p);
                        System.Console.WriteLine("Cadastrar um novo produto? s-sim, n-não");
                        string resposta = System.Console.ReadLine();
                        if (resposta == "s")
                        {
                            escolha = 1;
                        }
                        else
                        {
                            Console.WriteLine("Você deseja salvar os dados? s-sim n-não");
                            string escolha1 = Console.ReadLine();
                            if (escolha1 == "s")
                            {
                                Console.WriteLine("Escolha um nome para o arquivo: (Sem caracteres especiais e sem extensão .txt)");
                                meuproduto.nomearquivo = Console.ReadLine();
                                meuproduto.GravarArquivo();
                                Console.ReadLine();
                            }
                            escolha = 0;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Qual o produto que deseja visualizar? Ex: 1 .. n (vai mostrar de acordo com a ordem em que foi colocado)");
                        int codigo_v = int.Parse(Console.ReadLine());
                        Tela.MostrarProdutos(meuproduto.produtos[codigo_v - 1]);
                        Console.ReadLine();
                        escolha = 0;
                        break;
                    case 3:
                        break;
                }
            }
        }
    }
}
