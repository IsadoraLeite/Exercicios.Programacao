Console.WriteLine("\n DO WHILE");
#region Do While
bool chovendo = false;
do
{
    if (VerificarTempo() == "Chovendo")
    {
        chovendo = true;
        Console.WriteLine("Limpando Parabrisa");
    }
    else
        chovendo = false;
} while (chovendo);

string VerificarTempo()
{
    Random random = new();
    int numero = random.Next(1, 1000);
    if (numero % 2 == 0)
        return "Sol";
    else
        return "Chovendo";
}
#endregion


Console.WriteLine("\n FOR");
#region For
for (int i = 0; i <= 10; i++)
{
    if (i % 2 == 0)
        Console.WriteLine($"{i} É Par");
    else
        Console.WriteLine($"{i} É Ímpar");
}
#endregion


Console.WriteLine("\n FOR EACH");
#region Foreach
List<int> listaNumero = new() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
foreach (int numero in listaNumero)
    if (numero % 2 == 0)
        Console.WriteLine($"{numero} É Par");
    else
        Console.WriteLine($"{numero} É Ímpar");
#endregion
