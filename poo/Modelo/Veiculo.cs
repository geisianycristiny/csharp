using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo.Modelo
{
    public class Veiculo
    {
              //Atributos
       string marca;
       string modelo;
       int ano;
      double velocidadeAtual;

       //Construtor
       public Veiculo(string marca, string modelo, int ano, double velocidadeAtual)
       {
           this.marca = marca;
           this.modelo = modelo;
           this.ano = ano;
           this.velocidadeAtual  = velocidadeAtual;
       }

       public string GetMarca()
       {
        return marca = marca;
       }
       public void SetMarca(string marca)
       {
        this.marca = marca;
       }

        //Métodos Andar e Falar
        public void Acelerar()
        {
            Console.WriteLine($"{marca} {modelo} de {ano} está acelerando.");
        }
        public void Freiar()
        {
            Console.WriteLine($"{marca} {modelo} de {ano} freiou rapidamente");
        }
    }
}