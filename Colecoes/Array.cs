using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class Array {
        public static void Executar() {
            string[] alunos = new string[5];
            alunos[0] = "Anderson";
            alunos[1] = "Bia";
            alunos[2] = "Carlos";
            alunos[3] = "Daniela";
            alunos[4] = "Emanuel";

            foreach(var aluno in alunos) {
                Console.WriteLine(aluno);
            }
            Console.WriteLine();

            for (int i = 0; i < alunos.Length; i++)  {
                Console.WriteLine(alunos[i]);
            }

            double somatorio = 0;
            double somatorio2 = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };
            double[] notas2 = { 9.7, 4.8, 8.4, 8.2, 6.8 };

            foreach(var nota in notas) {
                somatorio += nota;
            }
            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            for (int i = 0; i < notas2.Length; i++)  {
                somatorio2 += notas2[i];
            }
            double media2 = somatorio2 / notas.Length;
            Console.WriteLine(media2);

            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);
        }
    }
}
