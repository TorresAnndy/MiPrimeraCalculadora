using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimeraCalculadora
{
    public partial class frmCalculadora : Form
    {
        double primerNumero = 0;
        string operador = "";
        bool nuevoNumero = true;

        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void numeros(object sender, int numero)
        {
            if (nuevoNumero)
            {
                this.txtResultados.Text = numero.ToString();
                nuevoNumero = false;
            }

            Button btn = (Button)sender;
            this.txtResultados.Text = (this.txtResultados.Text == numero.ToString()) ? btn.Text : this.txtResultados.Text + btn.Text;
        }


        private void Operador(Button btn)
        {
            // Si ya hay un operador, calcular el resultado y actualizar el operador y el estado.
            if (!string.IsNullOrEmpty(operador))
            {
                CalcularResultado();
                operador = btn.Text;
                nuevoNumero = true;
            }
            else
            {
                // Si no hay un operador, establecer el operador y almacenar el primer número.
                operador = btn.Text;
                primerNumero = double.Parse(this.txtResultados.Text);
                nuevoNumero = true;
            }
            MostrarOperador();
        }

        private void MostrarOperador()
        {
            if (!string.IsNullOrEmpty(this.txtResultados.Text))
            {
                this.txtResultados.Text += " " + operador + " ";
            } 
        }

        private void CalcularResultado()
        {
            double segundoNumero = double.Parse(this.txtResultados.Text);

            switch (operador)
            {
                case "+":
                    this.txtResultados.Text = (primerNumero + segundoNumero).ToString();
                    break;
                case "-":
                    this.txtResultados.Text = (primerNumero - segundoNumero).ToString();
                    break;
                case "*":
                    this.txtResultados.Text = (primerNumero * segundoNumero).ToString();
                    break;
                case "/":
                    // Manejar la división por cero.
                    if (segundoNumero != 0)
                        this.txtResultados.Text = (primerNumero / segundoNumero).ToString();
                    else
                        this.txtResultados.Text = "Error";
                    break;
            }
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            // Restablecer el cuadro de texto y las variables.
            this.txtResultados.Text = "0";
            primerNumero = 0;
            operador = "";
            nuevoNumero = true;
        }

        private void btigual_Click(object sender, EventArgs e)
        {
            CalcularResultado();
            operador = "";
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            numeros(sender, 0);
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            numeros(sender, 1);
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            numeros(sender, 2);
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            numeros(sender, 3);
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            numeros(sender, 4);
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            numeros(sender, 5);
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            numeros(sender, 6);
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            numeros(sender, 7);
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            numeros(sender, 8);
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            numeros(sender, 9);
        }

        private void btSuma_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Operador(btn);
        }

        private void btResta_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Operador(btn);
        }

        private void btMultiplicar_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Operador(btn);
        }

        private void btDividir_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Operador(btn);
        }
    }
}

