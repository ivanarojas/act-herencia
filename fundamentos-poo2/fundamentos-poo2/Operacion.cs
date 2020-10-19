using System;
using System.Collections.Generic;
using System.Text;

namespace fundamentos_poo2
{
    public class Operacion
    {
        private int valor1;
        private int valor2;
        private int resultado;

        public int Valor1 {
            get { return valor1; }
            set { valor1 = value; }
        }
        public int Valor2
        {
            get { return valor2; }
            set { valor2 = value; }
        }

        public int Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }
    }

    public class Suma:Operacion
    {
        public void Sumar()
        {
            Resultado = Valor1 + Valor2;
        }
    }
}
