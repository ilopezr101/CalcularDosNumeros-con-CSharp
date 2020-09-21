using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularDosNumeros
{
    public class Valores
    {
        //Atributo

        public double numero1;
        public double numero2;

        // Métodos Setter & Getter

        public void setNumero1(double valor)
        {
            this.numero1 = valor;
        }

        public double getNumero1()
        {
            return this.numero1;

        }

        public void setNumero2(double valor)
        {
            this.numero2 = valor;
        }

        public double getNumero2()
        {
            return this.numero2; 
        }

    }
}
