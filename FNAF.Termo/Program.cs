List<string> nomes = new List<string> { "Freddy", "Chica", "Bonnie", "Foxy", "Golden Freddy", "Puppet", "SpringTrap", "Mangle", "Ballon Boy", "Toy Freddy", "Toy Chica", "Toy Bonnie" };
Random random = new Random();
string nomeSelecionado = nomes[random.Next(0, nomes.Count)];
string letrasEscondidas = "";

string respostaUser = "";

for (int i = 0; i < nomeSelecionado.Length; i++)
{
    letrasEscondidas += "x";
}

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine(".° JOGO DO TERMO °.");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Tema: Fnaf");
Console.WriteLine($"{letrasEscondidas}");
do
{
    Console.WriteLine("\nDigite a palavra");
    respostaUser = Console.ReadLine();

    if (respostaUser.ToLower() == nomeSelecionado.ToLower())
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"Você acertou, o personagem era: {nomeSelecionado}");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else if (respostaUser.ToLower().Length == nomeSelecionado.ToLower().Length)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nAcertou o tamanho!\n");
        Console.ForegroundColor = ConsoleColor.White;

        letrasEscondidas = "";

        for (int i = 0; i < nomeSelecionado.Length; i++)
        {
            nomeSelecionado.Contains(respostaUser.Substring(i, 1));
            if (respostaUser.ToLower().Substring(i, 1) == nomeSelecionado.ToLower().Substring(i, 1))
            {
                Console.Write(respostaUser[i]);
            }
            else if (nomeSelecionado.Contains(respostaUser.ToLower().Substring(i, 1)))
            {
                Console.Write("-");
            }
            else
            {

                Console.Write("x");

            }

        }
    }
} while (respostaUser.ToLower() != nomeSelecionado.ToLower());