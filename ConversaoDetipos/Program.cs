Console.WriteLine("Conversão de tipos \n");


//byte -> 1 byte
//short -> 2 bytes
//int -> 4 bytes
//long -> 8 bytes 
//float -> 4 bytes
//double -> 8 bytes
//decimal -> 16 bytes

//Converção implicida
int varInt = 20;
double varDouble = varInt;
Console.WriteLine(varDouble + "\n");

int numeroInt1 = 12312412;
long numeroLong = numeroInt1;
double nuemroDouble = numeroInt1;
decimal nuemroDecimal = numeroInt1;

Console.WriteLine(numeroInt1);
Console.WriteLine(numeroLong);
Console.WriteLine(nuemroDouble);
Console.WriteLine(nuemroDecimal + "\n");


//Conversão explicíta
double vardd = 1.2345;
int varii = (int)vardd; //perda de precisão por causa do tamnho inferior de bytes
Console.WriteLine(varii + "\n");

int num1 = 21;
int num2 = 4;
decimal resultado = (decimal) num1 / num2;
Console.WriteLine(resultado + "\n");


Console.ReadLine();




