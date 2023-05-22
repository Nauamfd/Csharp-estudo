using System.Diagnostics.Tracing;

Console.WriteLine("Constantes \n");

//Constante é obrigatório atribui-la
const int IDADE = 21;

//Várias variáveis const, mas do mesmo tipo, sempre atribuindo um valor
const int NUMERO = 1, DIA = 31, PULAR = 3;

//Constante atriuido através de uma divisão 
const float DIAS_PULADOS = (float)DIA / (float)PULAR;
Console.WriteLine(DIAS_PULADOS);



Console.ReadKey();
