//1 - Crie uma variável chamada idade e atribua a ela o valor 35 e exiba o seu valor

using System.Collections.ObjectModel;
using System.Drawing;
using System.Globalization;
using System.IO.Pipes;
using static System.Runtime.InteropServices.JavaScript.JSType;

int? idade = null;

Console.WriteLine("Qual é a sua idade?");
idade = (int)int.Parse(Console.ReadLine());

Console.WriteLine($"A sua idade é: {idade}");

Console.WriteLine();
Console.WriteLine("-------------------------------");    

//2 - Crie uma variável chamada nome e atribua o valor "Maria" e exiba o seu valor.

string? nome = null;

Console.WriteLine("Qual é o seu nome?");
nome = Console.ReadLine();
Console.WriteLine($"Seu nome é: {nome}");

Console.WriteLine();
Console.WriteLine("-------------------------------");

//3 - Crie uma variável chamada altura e atribua a ela o valor 3.45.
var culture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
culture.NumberFormat.NumberDecimalSeparator = ".";

decimal? altura = null;
Console.WriteLine($"Qual é sua altura {nome}?");
altura = (decimal)decimal.Parse(Console.ReadLine(), culture);
Console.WriteLine($"A sua altura é {altura}");

Console.WriteLine();
Console.WriteLine("-------------------------------");

//4 - Crie uma variável chamada data e atribua a ela a data 04/09/1999 e exiba o seu valor
DateOnly data = new();


Console.WriteLine("Qual é a sua data de nascimento? escreva nessa ordem {Ano/Mes/Dia}");
data = DateOnly.Parse(Console.ReadLine());
Console.WriteLine($"Data em que você nasceu é {data}");

Console.WriteLine();
Console.WriteLine("-------------------------------");


//5 - Crie uma constante chamada ano e atribua a ela o valor 12 e exiba o seu valor;
const int ano = 12;
Console.WriteLine($"A constante é {ano}");

Console.WriteLine();
Console.WriteLine("-------------------------------");

//6 - Declare uma variável nota do tipo double como sendo do tipo Nullable type e atribua o valor 7.80 e exiba o seu valor
double? nota = null;
nota = 7.80d;
Console.WriteLine($"O valor inserido é `{nota}");

Console.WriteLine();
Console.WriteLine("-------------------------------");

//7 - Quais as diferenças entre os tipos por valor e os tipos por referência ?
Console.WriteLine("Os tipos de valor, ele são dados onde podem ser atribuidos novos valores, e manipular esse valores, ele já vem pré definidos" +
    " por exemplo os int, decimal e float, quem vem atribuido com o número 0, já os refenrência, não tem valores atribuidos, ou seja não são pré definidos" +
    "ele são manipulados e atribuidos á través de uma referência, por exemplo, obj, string e dymic.");

Console.WriteLine();
Console.WriteLine("-------------------------------");

//8 - Inclua o tipo de dados correto entre os parênteses nas seguintes declarações de variáveis:

Console.WriteLine("(int) x = 10;");
Console.WriteLine("(double) numero = 7.99;");
Console.WriteLine("(char) letra = 'C';");
Console.WriteLine("float) temperatura = 27.4f;");
Console.WriteLine("bool) ativo = false;");
Console.WriteLine("(string) nome = Manoel");
Console.WriteLine("(decimal) salario = 950.99m;");
Console.WriteLine("(DateTime) hoje = DateTime.Now;");

Console.WriteLine();
Console.WriteLine("-------------------------------");

//9 - Dada as variáveis declaradas a seguir classifique-as em tipos por valor(V) e tipos por referência (R) 

Console.WriteLine("(V) int n = 1");
Console.WriteLine("(R) string titulo = A vida");
Console.WriteLine("(V) float f = 12.45f;");
Console.WriteLine("(V) double d = 5.45;");
Console.WriteLine("(V) decimal valor = 10.99m;");
Console.WriteLine("(R) char sexo = ‘M’;");
Console.WriteLine("(R) object o = null;");

Console.WriteLine();
Console.WriteLine("-------------------------------");

//10 - O que é um nullable type e qual a sua utilidade ?
Console.WriteLine("Tipo nullable, não tipos de dados que podem ser nulos.Que são usados para atribuir valores nulos do banco de dados");

Console.WriteLine();
Console.WriteLine("-------------------------------");

//11 - O que é Camel Case ? Dê um exemplo de sua aplicação.
Console.WriteLine("Os camel case, é um tipode indentificador usado para, dar nomes as variáveis. Exemplos: valorProduto e valor_produto");

Console.WriteLine();
Console.WriteLine("-------------------------------");

//12 - O que é Pascal Case ? Dê um exemplo de sua aplicação.
Console.WriteLine("Os Pascal Case, é outro tipo de indentificador, mas são usados para dar nomes à métodos e classes. Exemplos: class PessoaFisisca, método MostrarCpf ");

Console.WriteLine();
Console.WriteLine("-------------------------------");

/* 13 - Declare duas variáveis x e y como sendo do tipo int e atribua a ela os valores 77 e 66 e a 
 seguir imprima o valor da soma de x com y. (Use o operador aritmético + para realizar a operação de soma) */

int x = 77 , y = 66;
int resultado = x + y;
Console.WriteLine(resultado);

Console.WriteLine();
Console.WriteLine("-------------------------------");

//14- Quais os valores padrões dos tipos de dados bool, char, int, double, float, decimal e string.
bool bol12 = false;
char cha12 = '\0';
int ink = 0;
double doul = 0;
float fl12 = 0;
decimal ddf = 0;
string? stre = "null";

Console.WriteLine(bol12.ToString());
Console.WriteLine(cha12.ToString());
Console.WriteLine(ink.ToString());
Console.WriteLine(doul.ToString());
Console.WriteLine(fl12.ToString());
Console.WriteLine(ddf.ToString());
Console.WriteLine(stre);

Console.WriteLine();
Console.WriteLine("-------------------------------");

/*15- Indique verdadeiro(V) ou falso (F) para as seguintes declarações de variáveis 
considerando a nomenclatura usada:
*/

Console.WriteLine("(F) double 1valor = 12.45;");
Console.WriteLine("(F) string #nome = Pedro");
Console.WriteLine("(V) float _temperatura = 12.45f;");
Console.WriteLine("(V) double int = 5;");
Console.WriteLine("(F) decimal renda extra = 91.45m;");
Console.WriteLine("(F) bool status$conta = false;");
Console.WriteLine("(V) string titulo3 = “Tópico 1”;");
Console.WriteLine("(V) float salario_mensal = 1999.55f;");
Console.WriteLine("(V) int percentualValorDesconto = 5;");
Console.WriteLine("(V) const bool MENSALIDADE_EM_DIA = true;");

