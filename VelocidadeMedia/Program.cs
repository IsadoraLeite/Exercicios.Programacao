double Si = 0;
double Sf = 0;
double Ti = 0;
double Tf = 0;
double KmCalculo = 0;
double tempoCalculo = 0;
double RespostaKm = 0;
double RespostaMs = 0;

Console.WriteLine("Qual foi a distância da viagem?");
Sf = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Quantas horas teve a viagem?");
Tf = Convert.ToDouble(Console.ReadLine());

KmCalculo = Sf - Si;
tempoCalculo = Tf - Ti;

RespostaKm = KmCalculo / tempoCalculo;

RespostaMs = RespostaKm / 3.6;

Console.Clear();

Console.WriteLine($"A velocidade média durante a viagem foi de {RespostaKm} Km/h.");
Console.WriteLine($"A velocidade média durante a viagem foi de {RespostaMs.ToString("F2")} m/s.");
