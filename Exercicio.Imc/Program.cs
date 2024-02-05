double peso = 0;
double altura = 0;
double IMC = 0;

Console.WriteLine($"Insira seu peso");
peso = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Insira sua altura");
altura = Convert.ToDouble(Console.ReadLine());

IMC = peso / (altura * altura);

if (IMC < 18)
{
    Console.WriteLine($"IMC é: {IMC}\n" +
        $"Abaixo do peso");
}

if (IMC > 20 && IMC < 25)
{
    Console.WriteLine($"IMC é: {IMC}\n" +
        $"Normal");
}

if (IMC > 25 && IMC < 30)
{
    Console.WriteLine($"IMC é: {IMC}\n" +
        $"Acima do peso");
}

if (IMC > 30 && IMC < 35)
{
    Console.WriteLine($"IMC é: {IMC}\n" +
        $"Obesidade classe |");
}

if (IMC > 35 && IMC < 40)
{
    Console.WriteLine($"IMC é: {IMC}\n" +
        $"Obesidade classe ||");
}

if (IMC >= 40)
{
    Console.WriteLine($"IMC é: {IMC}\n" +
        $"Obesidade classe |||");
}