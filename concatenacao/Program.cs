// See https://aka.ms/new-console-template for more information
string nome1 = "wanderson";
string saudacao1= "Olá, "+ nome1 +"bem - vindo";
Console.WriteLine(saudacao1);

string nome2 = "Geisiany";
string saudacao2=$"Ola,{nome2}! Bem-vindo.";
Console.WriteLine(saudacao2);

int numero = 5;
Console.WriteLine(numero.GetType());

Console.WriteLine(typeof(int));

string valortexto= "100";
Console.WriteLine("A variavel valorTexto e do tipo:" + valortexto.GetType());

int numero3 = int.Parse(valortexto);
Console.WriteLine(numero3);
Console.WriteLine("A variavel numeroParse e do tipo:" + numero3.GetType());

string valorEmTexto = "100";
Console.WriteLine("A variavel valorTexto e do tipo:" + valorEmTexto.GetType());

int numeroConvertido = Convert.ToInt32(valorEmTexto);
Console.WriteLine(numeroConvertido);
Console.WriteLine("A variavel numeroConvertido e do tipo:" + numeroConvertido.GetType());