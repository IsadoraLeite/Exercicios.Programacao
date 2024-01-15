int respostaOpcao = 0;
int numero = 0;
double resultado1 = 0;
double resultado2 = 0;

do
{
    Console.WriteLine("1 - Fahrenheit para Celsius\n" +
        "2 - Celsius para Fahrenheit\n" +
        "3 -  Km/h para milhas\n" +
        "4 - milhas para Km/h\n" +
        "5 - sair");

    respostaOpcao = Convert.ToInt32(Console.ReadLine());

    if (respostaOpcao == 1)
    {
        Console.WriteLine("digite um numero");
        numero = Convert.ToInt32(Console.ReadLine());

        resultado1 = numero - 32;
        resultado2 = resultado1 / 1.8;
        Console.WriteLine($"esse foi o resultado:{resultado2} ");

    }
    else if (respostaOpcao == 2)
    {
        Console.WriteLine("digite um numero");
        numero = Convert.ToInt32(Console.ReadLine());

        resultado1 = numero * 1.8;
        resultado2 = resultado1 + 32;
        Console.WriteLine($"esse foi o resultado:{resultado2} ");


    }
    else if (respostaOpcao == 3)
    {
        Console.WriteLine("digite um numero");
        numero = Convert.ToInt32(Console.ReadLine());

        resultado2 = numero * 0.62137;
        Console.WriteLine($"esse foi o resultado:{resultado2} ");


    }
    else if (respostaOpcao == 4)
    {
        Console.WriteLine("digite um numero");
        numero = Convert.ToInt32(Console.ReadLine());

        resultado2 = numero / 0.62137;
        Console.WriteLine($"esse foi o resultado:{resultado2} ");


    }


} while (respostaOpcao != 5);