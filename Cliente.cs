using System;

class Cliente {
        public string Nome {get; set;}
        public string Cpf {get; set;}
        public int Idade {get; set;}
        public Plataforma Plat;

        public Cliente (string nome, string cpf, int idade, Plataforma plataforma) {
                Nome = nome;
                Cpf = cpf;
                Idade = idade;
                Plat = plataforma;
        }

        public Cliente () {

        }

         public string exibe()  {
                return "\nNome: " + Nome 
                + "\nCPF: " + Cpf
                + "\nIdade: " + Idade
                + "\nPlataforma: " + Plat.exibe();
                
        }

}