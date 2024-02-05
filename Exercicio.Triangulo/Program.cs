double lado1 = 0;
double lado2 = 0;
double lado3 = 0;

Console.WriteLine("Insira o tamanho do primeiro lado:");
lado1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Insira o tamanho do segundo lado:");
lado2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Insira o tamanho do terceiro lado:");
lado3 = Convert.ToDouble(Console.ReadLine());

if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
{

    if (lado1 == lado2 && lado1 == lado3)
    {
        Console.WriteLine("Triângulo Equilátero");
    }
    else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
    {
        Console.WriteLine("Triângulo Isósceles");
    }
    else
    {
        Console.WriteLine("Triângulo Escaleno");
    }
}
else
{
    Console.WriteLine("Triângulo Inválido");
}
