Console.WriteLine(" Conversão de tipos 2 \n");


//Conversão toString
int valorInt = 321;
double valorDouble = 13.56;
decimal valorDecimal = 14.54564m;

string s1 = valorInt.ToString();
string s2 = valorDouble.ToString();
string s3 = valorDecimal.ToString();

Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3 + "\n");




//Exemplo 2

int valor_int = 12;
double valor_double = 0;
bool valor_bool = true;

Console.WriteLine(Convert.ToString(valor_int));
Console.WriteLine(Convert.ToDouble(valor_int));
Console.WriteLine(Convert.ToString(valor_bool));
Console.WriteLine(Convert.ToInt32(valor_double));
Console.WriteLine(Convert.ToBoolean(valor_double));


//Exemplo de erro conversão de estreitamento de dados
//OverflowException(Estourou a capacidade)

int var_INT = 10232;
Console.WriteLine(Convert.ToByte(var_INT));




Console.ReadLine();

