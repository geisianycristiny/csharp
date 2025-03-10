using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace classes.modelo
{
    public class NewClass
    {
        public class Pessoa
        {
            string nome;
            int idade;
            double altura;
            double peso;

            public Pessoa(string nome, int idade, double altura, double peso)
            {
                this.nome = nome;
                this.idade = idade;
                this.altura = altura;
                this.peso = peso;

            }
            // metodos Andar e falar
            public void Andar()
            {
                Console.WriteLine($"{nome} EndOfStreamException andando.");
            }
            public void falar()
            {
                Console.WriteLine($"{nome} vou ficar rico programando em c#");
            }
            
        }
        
    }
}