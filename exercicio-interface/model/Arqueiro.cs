
         public class Arqueiro : Heroi
    {
        public Arqueiro(string nomeHeroi) : base(nomeHeroi) { }

        public override void Atacar()
        {
            Console.WriteLine(nome + " dispara uma flecha certeira!");
        }

        public override void Especial()
        {
            Console.WriteLine(nome + " usa a Flecha Explosiva para causar dano em área!");
        }
    }
    
