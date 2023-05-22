Console.WriteLine("Operadores Incremento e Decremento \n");

//Operadore de incremento
int x = 0;
x++;
Console.WriteLine(x);

//pós-incremento --> Primeiro resolve a questão despois incrementa
int y = 0;
Console.WriteLine($"Valor de y: {y}\n");


int resultado = y++ + 10;

Console.WriteLine($"Resultado de pos-incremento de y e: {resultado}\n");
//Então ele incrementa o y depois de resolver a expressão que é 0 + 10 = 10
Console.WriteLine($"Valor de y: {y}\n");

//pré-incremento --> Primeiro incrementa depois resolve a expressão

int z = 0;
int resulTado = ++z + 20;
//Primeiro incrementa z + 1 depois resolve a expressão
Console.WriteLine($"resultado de pre-incremento de z e:{resulTado}\n");
Console.WriteLine($"{z} \n");

//Operadore de decremento

int xp = 0;
xp--;
Console.WriteLine($"Valor de decremento de xp e:{xp}\n");


//Resolve a expressão, depois incrementa
int yp = 1;
int resultadoYP = yp-- + 10;
Console.WriteLine($"Valore de decremento de yp e:{resultadoYP}\n");
Console.WriteLine($"yp e:{yp}\n");

//Primeiro decrementa, depois resolve a expressão
int zp = 2;
int resultadoZP = --zp + 10;
Console.WriteLine($"Valore de decremento de zp e:{resultadoZP}\n");
Console.WriteLine($"zp e:{zp}\n");

Console.ReadKey();