// See https://aka.ms/new-console-template for more information
Console.WriteLine("Uélcomi tchu the Prougrami Calculeiti Lâmpada");

Console.WriteLine("Informe a potência da lâmpada: ");
int potenciaLampadaWatts = int.Parse(Console.ReadLine());

Console.WriteLine("Informe a largura do cômodo em metros: ");
decimal larguraComodoM = decimal.Parse(Console.ReadLine());

Console.WriteLine("Informe o comprimento do cômodo em metros: ");
decimal comprimentoComodoM = decimal.Parse(Console.ReadLine());

decimal areaComodoMQ = comprimentoComodoM * larguraComodoM;

decimal areaIluminadaPorLampada = potenciaLampadaWatts/18;

decimal lampadasNecessarias = areaComodoMQ/areaIluminadaPorLampada;

Console.WriteLine("Serão necessárias " +lampadasNecessarias.ToString("N0")+ " lâmpadas.");