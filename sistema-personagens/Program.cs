using System;

// Classe abstrata base
abstract class Personagem
{
    public string Nome { get; set; }
    public int Vida { get; set; }
    public int Forca { get; set; }

    public Personagem(string nome, int vida, int forca)
    {
        Nome = nome;
        Vida = vida;
        Forca = forca;
    }

    public abstract void Atacar();
    public abstract void Defender();

    public virtual void Especial()
    {
        Console.WriteLine($"{Nome} usa uma habilidade especial!");
    }
}

// Classes derivadas
class Guerreiro : Personagem
{
    public Guerreiro(string nome) : base(nome, 100, 20) { }

    public override void Atacar() => Console.WriteLine($"{Nome} ataca com uma espada!");
    public override void Defender() => Console.WriteLine($"{Nome} bloqueia com o escudo!");
}

class Mago : Personagem
{
    public Mago(string nome) : base(nome, 80, 10) { }

    public override void Atacar() => Console.WriteLine($"{Nome} lança um feitiço!");
    public override void Defender() => Console.WriteLine($"{Nome} cria uma barreira mágica!");
    public override void Especial() => Console.WriteLine($"{Nome} conjura um feitiço supremo!");
}

// Programa principal
class Program
{
    static void Main()
    {
        Personagem guerreiro = new Guerreiro("Arthur");
        Personagem mago = new Mago("Merlin");

        guerreiro.Atacar();
        guerreiro.Defender();

        Console.WriteLine();

        mago.Atacar();
        mago.Defender();
        mago.Especial();
    }
}