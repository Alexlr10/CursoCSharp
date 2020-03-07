using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Inferencia {
        public static void Executar() {
            var nome = "Leonardo";
            //nome = 123;
            Console.WriteLine(nome);

            //var idade;
            int  idade = 32;
            Console.WriteLine(idade);

            int a;
            a = 3;
            int b = 2;

            Console.WriteLine(a + b);
        }
    }
}
