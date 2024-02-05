int numEscolhido = 0;
int num1 = 1;
int resultado = 0;


Console.WriteLine("Quantas vezes deseja ver a tabuada?");
numEscolhido = Convert.ToInt32(Console.ReadLine());
Console.Clear();

for (int j = 0; num1 <= numEscolhido; num1++)
{

    for (int i = 0; i <= 10; i++)
    {

        resultado = num1 * i;
        Console.WriteLine($"{num1} x {i} = {resultado}");

    }
    Console.WriteLine("\n~\n");
}