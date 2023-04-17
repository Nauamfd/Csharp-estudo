using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescubraImparOuPar
{
    public class DescobrirImparOuPar
    {
        private int numero { get; set; }

       //Método que indentifica se o número informado e par ou impar
      public void IndentificarParOuImpar(int numero)
        {
            
            if(numero % 2 != 0)
            {
                Console.WriteLine($"O número {numero} é Impar\n");
            }
            else
            {
                Console.Write($"O número {numero} é Par \n");
            }

           
        }

    }
}
