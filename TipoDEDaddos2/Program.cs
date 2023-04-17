Console.WriteLine("Atribuindo valores a double, float e decimal");
Console.WriteLine();
double nDouble = 1.333;
float nFloat = 1.345f;
decimal nDecimal;
nDecimal = 2.888m;


Console.WriteLine(nDouble);
Console.WriteLine(nFloat);
Console.WriteLine(nDecimal);
Console.ReadLine();

Console.WriteLine("Comparando a precisão de casas dos repctivos valores float, double e decimal");

float x = 1f / 3f;
double y = 1d / 3d;
decimal z = 1m / 3m;

Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);