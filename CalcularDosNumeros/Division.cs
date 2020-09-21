using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularDosNumeros
{
    public class Division : Valores
    {
        public double dividir()
        {
            double valor1, valor2, resultado;

            valor1 = this.getNumero1();
            valor2 = this.getNumero2();

            resultado = valor1 / valor2;

            return resultado;
        }

    }
}
