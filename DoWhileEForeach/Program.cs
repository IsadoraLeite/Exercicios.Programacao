#region digitar palavra "parar"
string palavras = "";

do
{
    Console.WriteLine($"Digite uma palavra");
    palavras = Console.ReadLine();

} while (palavras.ToLower() != "parar");
#endregion

#region lista de palavras
List<string> palavras2 = new() { "Janela", "Banco", "Planta", "Boi", "Mesa" };

foreach (var palavra in palavras2)
    Console.WriteLine(palavra);
#endregion

#region soma de numeros de uma lista
List<int> numeros = new() { 10, 10, 10, 10, 10, 10 };
int resultado = 0;
foreach (var numero in numeros)
    resultado += numero;

Console.WriteLine(resultado);
#endregion
