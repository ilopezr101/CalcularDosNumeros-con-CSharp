using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CalcularDosNumeros
{
    public class Suma : Valores
    {
        public double Sumar()
        {
            double valor1, valor2, resultado;

            valor1 = this.getNumero1();
            valor2 = this.getNumero2();

            resultado = valor1 + valor2;

            return resultado;

        }
           
        
        

    }
}
