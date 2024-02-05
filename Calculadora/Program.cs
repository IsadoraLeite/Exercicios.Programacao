string operacao = "";
int num1 = 0;
int num2 = 0;
int resultado = 0;
List<string> historico = new();

do
{
    //Ctrl + K
    //Ctrl + D
    Console.Clear();

    Console.WriteLine("Escolha qual operação matemática deseja realizar:");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("5 - Historico de operações");
    Console.WriteLine("S - Sair");
    operacao = Console.ReadLine();

    Console.Clear();

    if (operacao.ToLower() == "s")
    {
        break;
    }

    Console.WriteLine("Insira o primeiro número");
    num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Insira o segundo número");
    num2 = Convert.ToInt32(Console.ReadLine());


    if (operacao == "1")
    {
        resultado = Soma(num1, num2);
        Console.WriteLine($"{num1} + {num2} = {resultado}");
    }
    else if (operacao == "2")
    {
        resultado = Subtracao(num1, num2);
        Console.WriteLine($"{num1} - {num2} = {resultado}");
    }
    else if (operacao == "3")
    {
        resultado = Multiplicacao(num1, num2);
        Console.WriteLine($"{num1} * {num2} = {resultado}");
    }
    else if (operacao == "4")
    {
        resultado = Divisao(num1, num2);
        Console.WriteLine($"{num1} / {num2} = {resultado}");
    }
    else if (operacao == "5")
    {
        foreach (var item in historico)
        {
            Console.WriteLine($"{item}");
        }
    }
    Console.ReadLine();
} while (true);

static int Soma(int num1, int num2)
{
    return num1 + num2;
}

static int Subtracao(int num1, int num2)
{
    return num1 - num2;
}

static int Multiplicacao(int num1, int num2)
{
    return num1 * num2;
}

static int Divisao(int num1, int num2)
{
    return num1 / num2;
}