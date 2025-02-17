int idade = 16;
bool autorizado = false;

if (idade >= 18)
{
    Console.WriteLine("Entrada Liberada.");
}
else if (idade < 18)
{
    if (autorizado)
    {
        Console.WriteLine("Entrada Liberada.");
    }
    else
    {
    Console.WriteLine("Entrada nao permitida.");
    }
}



Console.WriteLine("O aluno possui a presença minima? (sim/nao):");
string presença = Console.ReadLine().ToLower();
if(presença == "sim")
{
    Console.WriteLine("Digite a media do aluno:");
    double media = double.Parse(Console.ReadLine());

    if(media >= 7)
    {
        Console.WriteLine("Aprovado!");
    }
    else
    {
        Console.WriteLine("Reprovado!");
    }
}
else 
{
    Console.WriteLine("Reprovado.");
}
