﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int numero = 10;
if (numero > 0)
{
    Console.WriteLine("O numero e positivo");
}

double nota1 = 5.5;
double nota2 = 8.0;
double nota3 = 6.8;
double media = (nota1+nota2+nota3)/3;
if(media>=7)
{
    Console.WriteLine($"Media{media:F2} Aprovado");
}
else
{
    Console.WriteLine($"Media{media:F2}recuperação");
}

double nota4 = 5.5;
double nota5 = 8.0;
double nota6 = 6.8;
double mediaNota = (nota4+nota5+nota6)/3;
if(media>=7)
{
    Console.WriteLine($"Media{mediaNota:F2} Aprovado");
}
else if (mediaNota>=5 && mediaNota<7)
{
    Console.WriteLine($"Media{mediaNota:F2}recuperação");
}
else{
    Console.WriteLine($"Media{mediaNota:F2}:reprovado");
}

Console.WriteLine("Digite uma letra:");
string letra = Console.ReadLine();
if (letra == "a" || letra == "A")
{
    Console.WriteLine($"A letra {letra} e uma vogal.");
}
else if (letra == "e" || letra =="E")
{
    Console.WriteLine($"A letra {letra} e uma vogal.");
}
else if (letra == "I")
{
    Console.WriteLine($"A letra {letra} e uma vogal");
}

else if (letra == "o" || letra == "O")
{
    Console.WriteLine($"A letra {letra} e uma vogal.");
}       

else if (letra == "u" || letra == "U")
{
    Console.WriteLine($"A letra {letra} e uma vogal.");
}
else
{
    Console.WriteLine($"A letra {letra} nao e uma vogal.");
}

string dia = "segunda";

switch(dia)
{
    case"segunda":
    Console.WriteLine("começo da semana");
    break;
    Console.WriteLine("fim de semana chegando");
    break;
    default:
    Console.WriteLine("Dia qualquer");
    break;
}

Console.WriteLine("Digite uma vogal");
string letra1 = Console.ReadLine();
string letraMinuscula = letra1.ToLower();
switch (letraMinuscula)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
    Console.WriteLine($"A letra '{letraMinuscula}' e uma vogal");
    break;
    default:
    Console.WriteLine("A letra '{letraMinuscula}' nao e uma vogal");
    break;
}

int idade = 18;
string mensagem = idade >= 18? "Maior de idade" : "Menor de idade";
Console.WriteLine(mensagem);