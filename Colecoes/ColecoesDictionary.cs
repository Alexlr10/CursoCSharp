using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class ColecoesDictionary {
        public static void Executar() {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem-Aranha");
            filmes.Add(2004, "Os Inscriveis");
            filmes.Add(2006, "O grande Truque");

            if (filmes.ContainsKey(2004)) {
                Console.WriteLine("2004: " + filmes[2004]);
                Console.WriteLine("2004: " + filmes.GetValueOrDefault(2004));
            }
         

                    filmes.TryGetValue(2016, out string filme2006);
                    Console.WriteLine($"Filme {filme2006}!");

                    foreach(var chave in filmes.Keys) {
                        Console.WriteLine($"Filme {filme2006}!");
                    }
                      foreach(var valor in filmes.Values) {
                        Console.WriteLine(valor);
                    }
                    foreach (KeyValuePair<int, string> filme in filmes) {
                        Console.WriteLine($"{filme.Value} é {filme.Key}");
                    }
                        foreach(var filme in filmes) {
                            Console.WriteLine($"{filme.Value} é {filme.Key}");
                        }
                    

                
            }
        }
    }

