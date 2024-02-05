#region tarefa one


Console.WriteLine($"Digite o ano de nascimento:");
int RespostaAno = Convert.ToInt32(Console.ReadLine());

if (RespostaAno <= 2005)
{

    Console.WriteLine($"Deverá Votar.");
}
else
{
    Console.WriteLine($"Espere mais uns anos.");
}
#endregion

#region tarefa two
Console.WriteLine($"Digite o primeiro número");
int Numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Digite o segundo número");
int Numero2 = Convert.ToInt32(Console.ReadLine());

int resultadosoma = Numero1 + Numero2;
Console.WriteLine($"{Numero1} + {Numero2} = {resultadosoma}");

int resultadosubtraçao = Numero1 - Numero2;
Console.WriteLine($"{Numero1} - {Numero2} = {resultadosubtraçao}");

int resultadodivisao = Numero1 / Numero2;
Console.WriteLine($"{Numero1} / {Numero2} = {resultadodivisao}");

int resultadomultiplicaçao = Numero1 * Numero2;
Console.WriteLine($"{Numero1} * {Numero2} = {resultadomultiplicaçao}");



#endregion

#region tarefa three 
Console.WriteLine($"Digite o primeiro número");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Digite o segundo número");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Digite o terceiro número");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    if (num1 > num3)
    {
        Console.WriteLine($"{num1} é o maior");
    }
    else
    {
        Console.WriteLine($"{num3} é o maior");
    }
}
else
{
    if (num2 > num3)
    {
        Console.WriteLine($"{num2} é o maior");
    }
    else
    {
        Console.WriteLine($"{num3} é o maior");
    }
}



#endregion

#region tarefa four
List<int> numeros = new() { 20, 4, 8, 50, 82, 46, 30, 70, 99, 6 };
int maiorNumero = 0;
foreach (var item in numeros)
{
    if (item > maiorNumero)
    {
        maiorNumero = item;
    }
}
Console.WriteLine($"O maior número é: {maiorNumero}");

List<int> numeroslista = new() { 20, 4, 8, 50, 82, 46, 30, 70, 99, 6 };
int menorNumero = 1000;
foreach (var item in numeroslista)
{
    if (item < menorNumero)
    {
        menorNumero = item;
    }
}
Console.WriteLine($"O menor número é: {menorNumero}");

List<int> numerosmedia = new() { 20, 4, 8, 50, 82, 46, 30, 70, 99, 6 };
int media = 0;
foreach (var item in numerosmedia)
{
    media += item & item / 10;
}
Console.WriteLine($"A média número é: {media}");
#endregion

#region
List<int> numeross = new() { 20, 4, 8, 50, 82, 46, 30, 70, 99, 6 };
int soma = 0;
int mediaa = 0;
int maiorNumeroo = 0;
int menorNumeroo = numeross[0];

foreach (int numero in numeross)
{
    soma += numero;

    if (numero > maiorNumeroo)
    {
        maiorNumeroo = numero;
    }

    if (numero < menorNumeroo)
    {
        menorNumeroo = numero;
    }
}
media = soma / numeross.Count;
Console.WriteLine($"O menor número é: {menorNumero}");
Console.WriteLine($"O maior número é: {maiorNumero}");
Console.WriteLine($"A média é: {media}");
#endregion

#region tarefa gu agr
List<int> num = new();

Console.WriteLine("Digite um número: ");
num.Add(Convert.ToInt32(Console.ReadLine()));

Console.WriteLine("Digite um número: ");
num.Add(Convert.ToInt32(Console.ReadLine()));

Console.WriteLine("Digite um número: ");
num.Add(Convert.ToInt32(Console.ReadLine()));

num.Sort();
Console.Clear();
foreach (int i in num)
{
    Console.WriteLine(i);
}
#endregion