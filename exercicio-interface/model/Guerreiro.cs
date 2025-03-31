
    public class Guerreiro : Heroi
    {
        public Guerreiro(string nomeHeroi) : base(nomeHeroi) { }

        public override void Atacar()
        {
            Console.WriteLine(nome + " ataca com sua espada!");
        }

        public override void Especial()
        {
            Console.WriteLine(nome + " usa o Grito de Guerra para aumentar o ataque!");
        }
    }

    
