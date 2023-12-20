Console.WriteLine("## Struct DateTime ##\n");

//DateTime dataAtual = DateTime.Now;
//Console.WriteLine(dataAtual);

//criar uma data especifica usa formato: aaa,mm,dd
//DateTime dataHoje = new DateTime(2022, 09, 06);
//Console.WriteLine(dataHoje);

//definir as horas usa formato: aaa,mm,dd,hh,mm,ss
//DateTime dataHoraHoje = new DateTime(2022, 09, 06, 21, 10, 30);
//Console.WriteLine(dataHoraHoje);


DateTime hoje = DateTime.Now;
Console.WriteLine($"hoje: {hoje}\n");
//extrair informações da data atual
Console.WriteLine(hoje.Year);
Console.WriteLine(hoje.Month);
Console.WriteLine(hoje.Day);
Console.WriteLine(hoje.Hour);
Console.WriteLine(hoje.Minute);
Console.WriteLine(hoje.Second);
Console.WriteLine(hoje.Millisecond);

Console.WriteLine();

//adicionando valores
Console.WriteLine(hoje.AddDays(30));
Console.WriteLine(hoje.AddMonths(1));
Console.WriteLine(hoje.AddHours(2));
Console.WriteLine(hoje.AddYears(5));

Console.WriteLine();

//obter dia da semana e do ano
Console.WriteLine(hoje.DayOfWeek);
Console.WriteLine(hoje.DayOfYear);

Console.WriteLine();

//data no formato longo e curto
Console.WriteLine(hoje.ToLongDateString());
Console.WriteLine(hoje.ToShortDateString());

Console.WriteLine();

Console.WriteLine(hoje.ToLongTimeString());
Console.WriteLine(hoje.ToShortTimeString());


Console.ReadKey();
