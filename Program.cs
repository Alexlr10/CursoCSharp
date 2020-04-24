using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using Encapsulamento;
using CursoCSharp.Exceçoes;
using CursoCSharp.Api;

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
               //Colecoes
                {"Array - Colecoes", Colecoes.Array.Executar},
                {"List - Colecoes", ColecoesList.Executar},
                {"ArrayList - Colecoes", ColecoesArrayList.Executar},
                {"Set - Colecoes", ColecoesSet.Executar},
                {"Queue - Colecoes", ColecoesQueue.Executar},
                {"Igualdade - Colecoes", Igualdade.Executar},
                {"ColecoesStack - Colecoes", ColecoesStack.Executar},
                {"Dictionary - Colecoes", ColecoesDictionary.Executar},
               //OO
                {"Heranca - OO", Heranca.Executar},
                {"ConstrutorThis - OO", ConstrutorThis.Executar},
                {"Encapsulamento - OO", OO.Encapsulamento.Executar},
                {"Polimorfismo - OO", Polimorfismo.Executar},
                {"Abstract - OO", Abstract.Executar},
                {"Interface - OO", Interface.Executar},
                {"Sealed - OO", Sealed.Executar},
               //Metodos e Funções
                {"ExemploLambda - Metodos & Funções", ExemploLambda.Executar},
                {"LambdasDelegate - Metodos & Funções", LambdasDelegate.Executar},
                {"UsandoDelegates - Metodos & Funções", UsandoDelegates.Executar},
                {"DelegateFunAnonima - Metodos & Funções", DelegateFunAnonima.Executar},
                {"DelegatesComoParametros - Metodos & Funções", DelegatesComoParametros.Executar},
                {"MetodosDeExtensao - Metodos & Funções", MetodosDeExtensao.Executar},
               //Exceçoes
                {"PrimeiraExceçao - Exceções", PrimeiraExceçao.Executar},
                {"ExcecoesPersonalizadas - Exceções", ExcecoesPersonalizadas.Executar},
               //Api
                {"PrimeiroArquivo - Usando Api", PrimeiroArquivo.Executar},
                {"LendoArquivos - Usando Api", LendoArquivos.Executar},
                {"ExemploFileInfo - Usando Api", ExemploFileInfo.Executar},
                {"Diretorios - Usando Api", Diretorios.Executar},
                {"ExemploDirectoryInfo - Usando Api", ExemploDirectoryInfo.Executar},
                {"ExemploPath - Usando Api", ExemploPath.Executar},
                {"ExemploDateTime - Usando Api", ExemploDateTime.Executar},
            }) ;

            central.SelecionarEExecutar();
        }
    }
}