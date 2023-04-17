Console.WriteLine("Saída de dados : Formatação");
Console.WriteLine();



//Usar concatenação
Console.Write("-----------------Concatenação----------------------");
Console.WriteLine();
Console.WriteLine("Qual seu filme favorito");
String filme = Console.ReadLine();
Console.Write("O seu filme fávorito é:" + filme);
Console.WriteLine();


//Usar Interpolação 
Console.Write("-----------------Interpolação----------------------");
Console.WriteLine();
Console.WriteLine("De quem você gosta");
String nomePessoa = Console.ReadLine();
Console.WriteLine($"Você gosta do(a): {nomePessoa}");
Console.WriteLine();

//USar Place Holder 
Console.Write("-----------------Place_Holder ----------------------");
Console.WriteLine();
Console.WriteLine("O que você comeu hoje?");
String comida = Console.ReadLine();
Console.WriteLine("Você comeu:{0} assistindo seu filme favorito {1}, com o(a) {2}", comida, filme, nomePessoa);

Console.ReadKey();