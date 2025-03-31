
         public class Mago : Heroi
    {
        public Mago(string nomeHeroi) : base(nomeHeroi) { }

        public override void Atacar()
        {
            Console.WriteLine(nome + " lança uma bola de fogo!");
        }

        public override void Especial()
        {
            Console.WriteLine(nome + " usa uma magia poderosa para regenerar mana!");
        }
    }
    
