Console.WriteLine("Valores relacionais \n");

//(==) Compara dois valores, se é verdadeiro ou falso
int a = 24;
int b = 23;
bool resultado = a == b;
Console.WriteLine($"24 é igual a 23?: {resultado}\n");


//Comparar strings

string c = "Nauam";
string d = "João";
bool resultado2 = c == d;

Console.WriteLine($"O nome Nauam é igual a do João?: {resultado2}\n");

//Ou pode usar a o método Equals, onde é usada para comparar strings
Console.WriteLine($"{c.Equals(d)}\n");

//(>) Onde compara se o valor é maior
bool resultadoMaior = a > b;
Console.WriteLine($"24 é maior que 23?: {resultadoMaior} \n");

//(<) Onde compara se o valor é menor
bool resultadoMenor = b < a;
Console.WriteLine($"23 é menor que 24?: {resultadoMenor}\n");

//(>=) Onde compara se o valor é maior ou igual
bool resultadoMaiorOuigual = a >= b;
Console.WriteLine($"24 é maior ou igual que 23?: {resultadoMaiorOuigual} \n");

//(<+) Onde compara se o valor é menor ou igual
bool resultadoMenorOuigual = a <= b;
Console.WriteLine($"24 é menor ou igual que 23?: {resultadoMenorOuigual}\n");

//(!=) Onde compara se o valor é diferente
bool resultadoDiferente = a != b;
Console.WriteLine($"24 é diferente de 23?: {resultadoDiferente}");

Console.ReadLine();
