using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03.Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GetListaString();
            GetListaProdutos();
            Console.ReadKey();
        }

        // método para definir lista de string
        static void GetListaString()
        {
            List<string> nomes = new List<string>();

            // Add(Item)
            nomes.Add("João");
            nomes.Add("Antonio");
            nomes.Add("Barbara");
            nomes.Add("Wanderley");
            nomes.Add("Lívia");
            
            // Insert(index, item) -> define onde por
            nomes.Insert(5, "Amanda");

            // Remove(Item)
            nomes.Remove("João");

            // Listando os nomes usando Foreach
            foreach(var item in nomes)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', 20));

            // Listando os nomes na estrutura for
            for (int i = 0; i < nomes.Count; i++)
            {
                Console.WriteLine(nomes[i]);
            }
            Console.WriteLine(new string('-', 20));

            // Colocando elementos em ordem
            nomes.Sort();
            foreach(var item in nomes)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', 20));
        }

        static void GetListaProdutos()
        {
            List<Produto> produtos = new List<Produto>()
            {
                new Produto(1, "Banana", 10.00),
                new Produto(2, "Uva", 20.00),
                new Produto(3, "Bolo", 30.00),
                new Produto(4, "Barra de ouro", 20000.00)
            };
            produtos.Add(new Produto(5, "Miojo", 2.00));

            foreach (var item in produtos)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine(new string('-', 20));
            
            produtos.Sort();

            foreach (var item in produtos)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine(new string('-', 20));
            
            produtos.Sort(new OrdenacaoPreco());
            foreach (var item in produtos)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine(new string('-', 20));
        }
    }
}
