string nome = "";
string compromisso = "";
int idade = 0;
int opcao = 0;
DateTime dataHora = DateTime.Now;
List<string> nomes = new List<string>();
List<int> idades = new List<int>();
List<DateTime> datasEHora = new List<DateTime>();
List<string> ListaCompromisso = new List<string>();

do
{
    Console.WriteLine("\n1 - Cadastrar Compromisso\n" +
        "2 - Mostrar Compromissos\n" +
        "3 - Sair");
    opcao = Convert.ToInt32(Console.ReadLine());

    Console.Clear();

    if (opcao == 1)
    {

        Console.WriteLine("Insira seu nome");
        nome = Console.ReadLine();
        nomes.Add(nome);


        Console.WriteLine("Insira sua idade");
        idade = Convert.ToInt32(Console.ReadLine());
        idades.Add(idade);

        Console.WriteLine("Insira seu compromisso");
        compromisso = Console.ReadLine();
        ListaCompromisso.Add(compromisso);


        Console.WriteLine("Insira a data e a hora");
        dataHora = Convert.ToDateTime(Console.ReadLine());
        datasEHora.Add(dataHora);

        Console.Clear();
    }
    else if (opcao == 2)
    {
        for (int i = 0; i < nomes.Count; i++)
        {
            Console.WriteLine($"{nomes[i]} - {idades[i]} - {ListaCompromisso[i]} - {datasEHora[i]}");
        }
    }
} while (opcao != 3);
