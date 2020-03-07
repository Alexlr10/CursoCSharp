using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {
        public static void Executar() {
            // area da circunferencia
            double raio = 4.5;
            const double PI =3.14;

            raio = 5.5;
            //PI = 3,1415;
            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Area é " + (area + 100));

            //Tipos internos
            bool estaChovendo = true;
            Console.WriteLine("Esta chovendo "+ estaChovendo);
            
            byte idade = 45;
            Console.WriteLine("Idade "+idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de gols "+saldoDeGols);
            
            short salario = short.MaxValue;
            Console.WriteLine("Salario "+ salario);
            
            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor int"+menorValorInt);
            
            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("Populaçao Brasileira " + populacaoBrasileira);

            long menorValorlong = long.MinValue;
            Console.WriteLine("Menor long " + menorValorlong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("Populacao Mundial " +populacaoMundial);

            //Pontos flutuantes

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço Computador "+precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00;
            Console.WriteLine("Valor Apple "+valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancia entre Estrelas "+distanciaEntreEstrelas);

            //Letras
            char letra = 'b';
            Console.WriteLine("Letra "+letra);

            string texto = "Seja bem vindo ao Curso de C#!";
            Console.WriteLine(texto);


        }
    }
}
