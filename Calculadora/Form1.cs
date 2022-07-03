using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private double valor1;
        private double valor2;

        private double resultado;
        private int operacion;
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //num 1
            textBoxDisplay.Text = textBoxDisplay.Text + "1";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            //num 0
            textBoxDisplay.Text = textBoxDisplay.Text + "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //num 2
            textBoxDisplay.Text = textBoxDisplay.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //num 3
            textBoxDisplay.Text = textBoxDisplay.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //num 4
            textBoxDisplay.Text = textBoxDisplay.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //num 5
            textBoxDisplay.Text = textBoxDisplay.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //num 6
            textBoxDisplay.Text = textBoxDisplay.Text + "6";
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            //num 7
            textBoxDisplay.Text = textBoxDisplay.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //num 8
            textBoxDisplay.Text = textBoxDisplay.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //num 9
            textBoxDisplay.Text = textBoxDisplay.Text + "9";
        }

        private void buttonSuma_Click(object sender, EventArgs e)
        {
            //boton suma
            operacion = 1;
            valor1 = Convert.ToDouble(textBoxDisplay.Text);
            textBoxDisplay.Text = "";
        }

        private void buttonResta_Click(object sender, EventArgs e)
        {
            //boton resta
            operacion = 2;
            valor1 = Convert.ToDouble(textBoxDisplay.Text);
            textBoxDisplay.Text = "";
        }

        private void buttonProducto_Click(object sender, EventArgs e)
        {
            //boton x
            operacion = 3;
            valor1 = Convert.ToDouble(textBoxDisplay.Text);
            textBoxDisplay.Text = "";

        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            //boton /
            operacion = 4;
            valor1 = Convert.ToDouble(textBoxDisplay.Text);
            textBoxDisplay.Text = "";
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            //boton igual
            valor2 = Convert.ToDouble(textBoxDisplay.Text);

            switch (operacion){
                case 1:
                    resultado = valor1 + valor2;
                    break;
                case 2:
                    resultado = valor1 - valor2;
                    break;
                case 3:
                    resultado = valor1 * valor2;
                    break;
                case 4:
                    resultado = valor1 / valor2;
                    break;
             }

            textBoxDisplay.Text = resultado.ToString();


        }

        private void buttonPunto_Click(object sender, EventArgs e)
        {
            //boton .
            textBoxDisplay.Text = textBoxDisplay.Text + ".";
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            //boton borrar
            textBoxDisplay.Text = "";
        }

        private void textBoxDisplay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
