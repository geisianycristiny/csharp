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