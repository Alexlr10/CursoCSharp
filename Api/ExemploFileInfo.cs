using System;
using System.IO;

namespace CursoCSharp.Api {
    class ExemploFileInfo {
        public static void Executar() {
            var caminhoOrigem = @"~/arq_origem.txt".parseHome();
            var caminhoDestino = @"~/arq_destino.txt".parseHome();
            var caminhoCopia = @"~/arq_copia.txt".parseHome();

            using (StreamWriter sw = File.CreateText(caminhoOrigem)) {
                sw.WriteLine("Arquivo original");
            }

            FileInfo origem = new FileInfo(caminhoOrigem);
            Console.WriteLine(origem.Name);
            Console.WriteLine(origem.IsReadOnly);
            Console.WriteLine(origem.FullName);
            Console.WriteLine(origem.Extension);
            Console.WriteLine(origem.DirectoryName);

            origem.CopyTo(caminhoCopia);
            origem.MoveTo(caminhoDestino);
        }

    }
}
