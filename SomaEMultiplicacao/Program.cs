string nome;
int resultadoSoma = 0;
int resultadoMultiplicacao = 0;
int num1;
int num2;
int num3;

Console.WriteLine("Digite seu nome");
nome = Console.ReadLine();

Console.WriteLine($"Olá {nome}!");


Console.WriteLine("Digite o primeiro número:");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o segundo valor:");
num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o terceiro valor");
num3 = Convert.ToInt32(Console.ReadLine());

resultadoSoma = (num1 + num2 + num3);
resultadoMultiplicacao = (num1 * num2 * num3);

Console.WriteLine($"O resultado é: {resultadoSoma}");
Console.WriteLine($"O resultado é: {resultadoMultiplicacao}");
