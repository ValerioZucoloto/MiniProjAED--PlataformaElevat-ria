using System;

class Plataforma {
        public string Fabricante {get; private set;}
        public double Alcance {get; set;}
        public string Modelo {get; set;}

        public Plataforma (string fabricante, double alcance, string modelo) {
                Fabricante = fabricante;
                Alcance = alcance;
                Modelo = modelo;
        }

        public Plataforma() {
                
        }

        

}