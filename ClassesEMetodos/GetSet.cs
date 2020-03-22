using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    public class Moto {
        private string Marca;
        private string Modelo;
        private uint Cilindrada;

        public Moto(string marca, string modelo, uint cilindrada) {
            /* marca = marca;
             modelo = modelo;
             cilindrada = cilindrada; */
            SetMarca("Honda");
            SetModelo("Broz");
            SetCilindrada(160);
        }
        public Moto() {

        }

        public string GetMarcar() {
            return Marca;
        }
        public void SetMarca(string marca) {
            Marca = marca;
        }

        public string GetModelo() {
            return Modelo;
        }
        public void SetModelo(string modelo) {
            Modelo = modelo;
        }
        public uint GetCilindrada() {
            return Cilindrada;
        }
        public void SetCilindrada(uint cilindrada) {
            // 1 opçao
            //if (cilindrada > 0) {
            //    Cilindrada = cilindrada;
            //}
            //2 opçao
            // Cilindrada = Math.Abs(cilindrada);
            Cilindrada = cilindrada;
        }


    }
    class GetSet {
        public static void Executar() {
            var moto1 = new Moto ("Kawasaki","Ninja ZX-6R",636);
            Console.WriteLine(moto1.GetMarcar());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

            var moto2 = new Moto();

            moto2.SetMarca("Honda");
            moto2.SetModelo("CG Titan");
            moto2.SetCilindrada(-150);
            Console.WriteLine(moto2.GetMarcar() + " " + 
                moto2.GetModelo()+ " " + moto2.GetCilindrada());

        }
    }
}
