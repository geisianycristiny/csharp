    public class Program
    {
        static void Main(string[] args)
        {
            Heroi guerreiro = new Guerreiro("Arthur");
            Heroi mago = new Mago("Merlin");
            Heroi arqueiro = new Arqueiro("Legolas");

            guerreiro.Atacar();
            guerreiro.Especial();

            mago.Atacar();
            mago.Especial();

            arqueiro.Atacar();
            arqueiro.Especial();
        }
    }

