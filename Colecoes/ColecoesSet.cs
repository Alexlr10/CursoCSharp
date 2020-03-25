using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {

    class ColecoesSet {
        public static void Executar() {
            var livro = new Produto("Game of Thrones",49.9);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto> {
                new Produto ("Camisa", 29.9),
                new Produto ("8ª temporada Game of Thrones", 99.9),
                new Produto ("Poster", 10),
             
            };

            carrinho.UnionWith(combo);
            Console.WriteLine(carrinho.Count);
          //  carrinho.RemoveAt(3);

            foreach (var item in carrinho) {
           //     Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Nome}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
         //   Console.WriteLine(carrinho.LastIndexOf(livro));
        }
    }
}
