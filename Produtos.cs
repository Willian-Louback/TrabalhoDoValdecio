using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDoValdecio
{
    public class Produtos
    {
        public int TotalProduto { get; set; }
        public string nomearquivo { get; set; }
        public string diretorio { get; set; }
        public List<Produto> produtos { get; set; }

        public Produtos()
        {
            produtos = new List<Produto>();
        }
        public void AdicionarProduto(Produto p)
        {
            produtos.Add(p);
        }
        public void RemoverProduto()
        {

        }
        public void GravarArquivo()
        {
            string diretorio = Directory.GetCurrentDirectory();
            diretorio = diretorio + @"\" + nomearquivo + ".txt";
            if (!System.IO.File.Exists(diretorio))
            {
                System.IO.File.Create(diretorio).Close();
            }
            string conteudo = "falta os dados";

            File.WriteAllText(diretorio, conteudo);
            Console.WriteLine("Os dados foram salvos em um arquivo com sucesso!");
            Console.WriteLine("Local do arquivo: " + diretorio);
        }
        public void CarregarArquivos()
        {

        }
    }
}
