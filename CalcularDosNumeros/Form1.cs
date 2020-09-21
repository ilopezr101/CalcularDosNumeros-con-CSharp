using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularDosNumeros
{
    public partial class Form1 : Form
    {
        Suma suma = new Suma();
        Resta resta = new Resta();
        Multiplicacion multiplicacion = new Multiplicacion();
        Division division = new Division();

        public Form1()
        {
            InitializeComponent();
        }



        private void btnSumar_Click(object sender, EventArgs e)
        {
            suma.setNumero1(double.Parse(txtValor1.Text));
            suma.setNumero2(double.Parse(txtValor2.Text));
            label5.Text = Convert.ToString(suma.Sumar());
            label4.Visible = true;
            label5.Visible = true;
        }

        private void BtnRestar_Click(object sender, EventArgs e)
        {
            resta.setNumero1(double.Parse(txtValor1.Text));
            resta.setNumero2(double.Parse(txtValor2.Text));
            label5.Text = Convert.ToString(resta.Restar());
            label4.Visible = true;
            label5.Visible = true;
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            multiplicacion.setNumero1(double.Parse(txtValor1.Text));
            multiplicacion.setNumero2(double.Parse(txtValor2.Text));
            label5.Text = Convert.ToString(multiplicacion.multiplicar());
            label4.Visible = true;
            label5.Visible = true;
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            division.setNumero1(double.Parse(txtValor1.Text));
            division.setNumero2(double.Parse(txtValor2.Text));
            label5.Text = Convert.ToString(division.dividir());
            label4.Visible = true;
            label5.Visible = true;
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtValor1.Text = String.Empty;
            txtValor2.Text = String.Empty;
            txtValor1.Focus();
            label4.Visible = false;
            label5.Visible = false;
        }
    }
}
