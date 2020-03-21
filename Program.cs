using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
               //Fundamentos 
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"VariaveisEConstantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar},
                {"Interpolacao - Fundamentos", Interpolacao.Executar},
                {"NotacaoPonto - Fundamentos", NotacaoPonto.Executar},
                {"LendoDados - Fundamentos", LendoDados.Executar},
                {"FormatandoNumero - Fundamentos", FormatandoNumero.Executar},
                {"Conversoes - Fundamentos", Conversoes.Executar},
                {"OperadoresAritmeticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"OperadoresRelacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"OperadoresLogicos - Fundamentos", OperadoresLogicos.Executar},
                {"OperadoresAtribuicao - Fundamentos", OperadoresAtribuicao.Executar},
                {"OperadoresUnarios - Fundamentos", OperadoresUnarios.Executar},
                {"OperadoresTernario - Fundamentos", OperadoresTernario.Executar},
               //Estruturas de Controle
                {"EstruturaIf - EstruturasDeControle", EstruturaIf.Executar},
                {"EstruturaIfElse - EstruturasDeControle", EstruturaIfElse.Executar},
                {"EstruturaIfElseIF - EstruturasDeControle", EstruturaIfElseIF.Executar},
                {"EstruturaSwitch - EstruturasDeControle", EstruturaSwitch.Executar},
                {"EstruturaWhile - EstruturasDeControle", EstruturaWhile.Executar},
                {"EstruturaDoWhile - EstruturasDeControle", EstruturaDoWhile.Executar},
                {"EstruturaFor - EstruturasDeControle", EstruturaFor.Executar},
                {"EstruturaForEach - EstruturasDeControle", EstruturaForEach.Executar},
                {"UsandoBreak - EstruturasDeControle", UsandoBreak.Executar},
                {"UsandoContinue - EstruturasDeControle", UsandoContinue.Executar},
               //Classes e Metodos
                {"Membros - Classes e Metodos", Membros.Executar},
                {"Construtores - Classes e Metodos", Construtores.Executar},
                {"MetodosComRetorno - Classes e Metodos", MetodosComRetorno.Executar},
            }) ;

            central.SelecionarEExecutar();
        }
    }
}