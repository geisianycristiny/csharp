    public abstract class Heroi : IAtacante
    {
        protected string nome;

        public Heroi(string nomeHeroi)
        {
            nome = nomeHeroi;
        }

        public abstract void Atacar();
        public abstract void Especial();
    }

