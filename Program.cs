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
                {"MetodosEstaticos - Classes e Metodos", MetodosEstaticos.Executar},
                {"AtributosEstatiscos - Classes e Metodos", AtributosEstatiscos.Executar},
                {"DesafioAtributo - Classes e Metodos", DesafioAtributo.Executar},
                {"Params - Classes e Metodos", Params.Executar},
                {"ParametrosNomeados - Classes e Metodos", ParametrosNomeados.Executar},
                {"GetSet - Classes e Metodos", GetSet.Executar},
                {"Props - Classes e Metodos", Props.Executar},
                {"Readonly - Classes e Metodos", Readonly.Executar},
                {"Enum - Classes e Metodos", ExemploEnum.Executar},
                {"Struct - Classes e Metodos", ExemploStruct.Executar},
                {"StructVsClasse - Classes e Metodos", StructVsClasse.Executar},
                {"ValorVsReferencia - Classes e Metodos", ValorVsReferencia.Executar},
                {"ParametrosPorReferencia - Classes e Metodos", ParametrosPorReferencia.Executar},
                {"ParametroPadrao - Classes e Metodos", ParametroPadrao.Executar},
            }) ;

            central.SelecionarEExecutar();
        }
    }
}