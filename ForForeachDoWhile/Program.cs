for (int i = 0; i <= 30; i++)
{
    Console.WriteLine(i.ToString());

}


for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"3 x {i} = {3 * i}");

}


int numero = 0;
do
{
    Console.WriteLine("Digite um número");
    numero = Convert.ToInt32(Console.ReadLine());

} while (numero != 0);


List<string> palavras = new() { "Janela", "Banco", "Planta", "Boi", "Mesa" };

foreach (string palavra in palavras)
{
    Console.WriteLine(palavra);
}
