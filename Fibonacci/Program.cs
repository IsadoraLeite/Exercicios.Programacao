int numEscolha = 0;
int numAnterior = -1;
int numAtual = 1;
int numResposta = 0;

Console.WriteLine($"Digite quantas vezes deseja que seja calculada a Fibonacci");
numEscolha = Convert.ToInt32(Console.ReadLine());

Console.Clear();

for (int i = 0; i < numEscolha; i++)
{
    numResposta = numAnterior + numAtual;
    Console.WriteLine(numResposta);

    numAnterior = numAtual;
    numAtual = numResposta;

}
