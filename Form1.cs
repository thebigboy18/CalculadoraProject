using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraProject
{
    public enum Operacion
    {
        NoDefinida = 0,
        Suma = 1,
        Resta = 2,
        Division = 3,
        Multiplicacion = 4,
        Modulo = 5,
    }
    public partial class Form1 : Form
    {
        double valor1 = 0;
        double valor2 = 0;
        Operacion operador = Operacion.NoDefinida;
        public Form1()
        {
            InitializeComponent();
        }

        private void LeerNumero(string numero)
        {
            if (cajaResultados.Text == "0" && cajaResultados.Text != null)
            {
                cajaResultados.Text = numero;
            }
            else
            {
                cajaResultados.Text += numero;
            }

        }
        private double EjecutarOperacion()
        {
            double resultado = 0;
            switch (operador)
            {
                case Operacion.Suma:
                    resultado = valor1 + valor2;
                    break;
                case Operacion.Resta:
                    resultado = valor1 - valor2;
                    break;
                case Operacion.Division:
                    if (valor2 == 0)
                    {
                        MessageBox.Show("No se puede dividir entre 0");
                        resultado = 0;
                    }
                    else
                    {
                        resultado = valor2 / valor1;
                    }
                    break;
                case Operacion.Multiplicacion:
                    resultado = valor1 * valor2;
                    break;
                case Operacion.Modulo:
                    resultado = valor1 % valor2;
                    break;
            }
            return resultado;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            LeerNumero("2");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LeerNumero("5");
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            if (cajaResultados.Text == "0")
            {
                return;
            }
            else
            { 
                cajaResultados.Text += "0";
            }
        }

        private void cajaResultados_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            LeerNumero("1");

        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            LeerNumero("4");
        }

        private void btnTrees_Click(object sender, EventArgs e)
        {
            LeerNumero("3");
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            LeerNumero("6");
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            LeerNumero("7");
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            LeerNumero("8");
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            LeerNumero("9");
        }

        private void ObtenerValor(string operador)
        {
            valor1 = Convert.ToDouble(cajaResultados.Text);
            lblHistorial.Text = cajaResultados.Text + operador;
            cajaResultados.Text = "0";
        }
        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = Operacion.Suma;
            ObtenerValor("+");
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if (valor2 == 0)
            {
                valor2 = Convert.ToDouble(cajaResultados.Text);
                lblHistorial.Text += valor2 + "=";
                double resultado = EjecutarOperacion();
                valor1 = 0;
                valor2 = 0;
                cajaResultados.Text = Convert.ToString(resultado);
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = Operacion.Resta;
            ObtenerValor("-");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            operador = Operacion.Multiplicacion;
            ObtenerValor("x");
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operador = Operacion.Division;
            ObtenerValor("/");
        }

        private void btnModulo_Click(object sender, EventArgs e)
        {
            operador = Operacion.Modulo;
            ObtenerValor("%");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cajaResultados.Text = "0";
            lblHistorial.Text = "";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (cajaResultados.Text.Length > 1)
            {
                string txtResultado = cajaResultados.Text;
                txtResultado = txtResultado.Substring(0, txtResultado.Length - 1);

                if (txtResultado.Length == 1 && txtResultado.Contains("-"))
                {
                    cajaResultados.Text = "0";
                }
                else
                {
                    cajaResultados.Text = txtResultado;
                }
                
            }
            else
            {
                cajaResultados.Text = "0";
            }
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
           if(cajaResultados.Text.Contains("."))
            {
                return;
            }
            cajaResultados.Text += ".";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
