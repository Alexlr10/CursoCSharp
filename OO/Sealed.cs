using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {
    sealed class SemFilho {
        public double ValorDaForturna() {
            return 1_407_033.65;
        }
    }
    //class SouFilho : SemFilho {

    //}

    class Avo {
        public virtual bool HonrarNomeFamilia() {
            return true;
        }
    }
    class Pai : Avo {
        public override sealed bool HonrarNomeFamilia() {
                return true;
            }
        }
        class FilhoRebelde : Pai {
            //public sealed override bool HonrarNomeFamilia() {
            //    return base.HonrarNomeFamilia(){
            //        return false;
        }

        class Sealed {
            public static void Executar() {
                SemFilho semFilho = new SemFilho();
                Console.WriteLine(semFilho.ValorDaForturna());

                FilhoRebelde filho = new FilhoRebelde();
                Console.WriteLine(filho.HonrarNomeFamilia());

            }
        }

    }
