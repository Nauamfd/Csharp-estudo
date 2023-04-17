
using DescubraImparOuPar;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProgramaImparPar
{
    public class Programa : DescobrirImparOuPar
    {
       static void Main(string[] args)
        {
            DescobrirImparOuPar dp = new DescobrirImparOuPar();
           
            Console.WriteLine("Programa para saber se seu número e impar ou par \n");
            Console.WriteLine("Digite o seu número: \n");
            Console.WriteLine("");

            dp.IndentificarParOuImpar(Convert.ToInt32(Console.ReadLine()));
        }
    }
}