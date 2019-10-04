using System;

class Plataforma {
        public string Fabricante {get; set;}
        public double Alcance {get; set;}
        public string Modelo {get; set;}
        public double Capacidade {get; set;}

        public Plataforma (string fabricante, double alcance, string modelo, double capacidade) {
                Fabricante = fabricante;
                Alcance = alcance;
                Modelo = modelo;
                Capacidade = capacidade;
        }

        public Plataforma() {
                
        }


        // Reservar a plataforma para o serviço
        public void reservarPlataforma (string model) {
                Modelo = model;
        }

        public string exibe()  {
                return "\nFabricante: " + Fabricante 
                + "\nAlcance: " + Alcance
                + "\nModelo: " + Modelo
                + "\nCapacidade: " + Capacidade;
        }



}