using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentos_poo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Suma objSuma = new Suma();
            objSuma.Valor1 = 2;
            objSuma.Valor2 = 4;
            objSuma.Sumar();
            Console.WriteLine("El resultado de la suma es: " + objSuma.Resultado);
        }
    }
}
