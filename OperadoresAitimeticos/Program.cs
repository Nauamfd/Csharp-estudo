using System.Net;

Console.WriteLine("Operadores Aritiméticos \n");

Console.WriteLine("Informe valor de x");
var x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y");
var y = Convert.ToInt32(Console.ReadLine());




Console.WriteLine($"Raiz quadrada de x = {Math.Sqrt(x)}");
Console.WriteLine($"Potência de x elevado a y = {Math.Pow(x,y)}");
Console.WriteLine($"Valor mínimo de x y y = {Math.Min(x, y)}");
Console.WriteLine($"Valor máximo de x e y = {Math.Max(x, y)}");
Console.WriteLine($"Coseno de x = {Math.Cos(x)}");
Console.WriteLine($"Seno x = {Math.Sin(x)}");
Console.WriteLine($"Exponencial de x = {Math.Exp(x)}");

var cha_a = new Cachorro();
cha_a.ChamarCachorro();

class Cachorro {
    public void ChamarCachorro()
    {
        Console.WriteLine("Bobbbbbbbbbbbb");
        Console.ReadKey();
    }
    

}



//Console.WriteLine($"A soma de x+y = {x + y}");
//Console.WriteLine($"A subtração de x-y = {x + y}");
//Console.WriteLine($"multiplicação de x*y = {x * y}");
//Console.WriteLine($"divisão de x/y = {Convert.ToDouble((double)x / y)}");
//Console.WriteLine($"módulo de x%y = {x % y}");
