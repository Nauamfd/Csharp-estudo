Console.WriteLine("Struct DateTime");

DateTime dataAtual = DateTime.Now;

Console.WriteLine(dataAtual);
Console.WriteLine();

//Criar uma data especifica usa formato: ano/mes/dia
DateTime dataHoje = new DateTime(2023, 04, 06);
Console.WriteLine(dataHoje);
Console.WriteLine();


//Definir horas horas/minutos/segundos
DateTime dataHoradeHoje = new DateTime(2023, 04, 06, 16, 27, 00);
Console.WriteLine(dataHoradeHoje);
Console.WriteLine();


//Extrair informações da data atual
DateTime dataAgora = DateTime.Now;

Console.WriteLine("Extraindo o ano {0}", dataAgora.Year);
Console.WriteLine("Extraindo o mes {0}", dataAgora.Month);
Console.WriteLine("Extraindo o dia {0}", dataAgora.Day);
Console.WriteLine("Extraindo a hora {0}", dataAgora.Hour);
Console.WriteLine("Extraindo os minutos {0}", dataAgora.Minute);
Console.WriteLine("Extraindo os segundos {0}", dataAgora.Second);
Console.WriteLine("Extraindo os milisegundos {0}", dataAgora.Millisecond);

Console.WriteLine("----------------------------------------------------------");
Console.WriteLine();

Console.WriteLine($"Hoje : {dataAgora}\n");
//Adicionando valores ou seja ele soma mais um dia
Console.WriteLine("Adicionando dias {0}", dataAgora.AddDays(1));
Console.WriteLine("Adicionando mes {0}", dataAgora.AddMonths(2));
Console.WriteLine("Adicionando horas {0}", dataAgora.AddHours(3));
Console.WriteLine("Adicionando anos {0}", dataAgora.AddYears(1));

Console.WriteLine("----------------------------------------------------------");
Console.WriteLine();

//Obter o dia da semana e do ano
Console.WriteLine("Dia da semana hoje,  {0}", dataAgora.DayOfWeek);
Console.WriteLine("Número de dias do ano {0}", dataAgora.DayOfYear);

//data no formato longo e curto
Console.WriteLine("Data formato longo {0}", dataAgora.ToLongDateString());
Console.WriteLine("Data formato curto {0}",dataAgora.ToShortDateString());

Console.WriteLine("----------------------------------------------------------");
Console.WriteLine();

//Horas no formato longo e curto
Console.WriteLine("Hora formato longo {0}", dataAgora.ToLongTimeString());
Console.WriteLine("Hora formato curto {0}", dataAgora.ToShortTimeString());


Console.ReadKey();

