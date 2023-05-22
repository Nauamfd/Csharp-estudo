Console.WriteLine("Valores nullable");

int valor = 100;

Console.WriteLine(valor.ToString());
Console.WriteLine("----------------");

//Valores que podem receber valores nulos
Nullable<int> i = null;
Nullable<double> d = null;
Nullable<bool> b = null;

Console.WriteLine(i);
Console.WriteLine(d);
Console.WriteLine(b);
Console.WriteLine("----------------");

//simplificar Valores nulos
char? ch = null;
String? sr = null;
DateTime? dt = null;

Console.WriteLine(ch);
Console.WriteLine(sr);
Console.WriteLine(dt);
Console.WriteLine("----------------");

/*Um valor null sempre vai ser null, então
int? a; = null => A variavel "a" e uma valor do tipo null 
int b = a; => Vai informar erro pois não pode atribuir
um valor null num valor que não do tipo null, e vise-versa.

Para atribuir um valor do tipo null para que não do tipo null,
usa-se ??
*/


/*Se a == a null então ele atribui o valor 0.
Mas se a estiver atribuido com um valor ele vai retornar
o mesmo valor
*/

int? a1 = null;

int b1 = a1 ?? 0;

Console.WriteLine(b1);
Console.WriteLine("----------------");

//Exemplo se o valor null estive-se com um valor atribuido

int? a2 = 1;

int b2 = a2 ?? 0;

Console.WriteLine(b2);

Console.WriteLine("----------------");

//O mesmo cuidado tem que ser atribuido em expressões

int x = 3;
int? y = null;
int t = y ?? 9;
int z = x * t;

Console.WriteLine(z);

Console.WriteLine("----------------");

int? r = 100;

if (r.HasValue)
{
   Console.WriteLine($"r = {r.Value}");
}
else
{
   Console.WriteLine("b não possui valor");
}


Console.ReadKey();
