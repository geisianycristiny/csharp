using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface.Modelo
{
    public class Gato : IAnimal, IDomestico {
        public void EmitirSom() {
            Console.WriteLine("Miando...");
        }
        public void Mover() {
            Console.WriteLine("Andando...");
        }
        public void AmassarPao() {
            Console.WriteLine("Amassando paozinho...");
        }
    }
    
        
    }
