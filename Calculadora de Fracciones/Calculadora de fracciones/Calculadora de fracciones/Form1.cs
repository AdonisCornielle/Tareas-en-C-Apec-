using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace S6G1_EJERC2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //declarando las variables a utilizar y asignando 
            double n1 = double.Parse(txt1.Text);
            double n2 = double.Parse(txt2.Text);
            double n3 = double.Parse(txt3.Text);
            double n4 = double.Parse(txt4.Text);
            double resultadoNumerador;
            double resultadoDenominador;
            double resultadoSimplificado;
            

            //Controlar los radiobutton mediante la estructura if
            
            
            if (rdbDiv.Checked==true) //Division
            {
                resultadoNumerador = n1 * n4;
                resultadoDenominador = n2 * n3;
                resultadoSimplificado = resultadoNumerador / resultadoDenominador;

                txtTotal.Text = Convert.ToString(resultadoNumerador);
                txtTotal2.Text = Convert.ToString(resultadoDenominador);
                txtTotal3.Text = Convert.ToString(resultadoSimplificado);
            }
            else if (rdbMul.Checked == true) //Multiplicacion
            {
                resultadoNumerador = n1 * n3;
                resultadoDenominador = n2 * n4;
                resultadoSimplificado = resultadoNumerador / resultadoDenominador;

                txtTotal.Text = Convert.ToString(resultadoNumerador);
                txtTotal2.Text = Convert.ToString(resultadoDenominador);
                txtTotal3.Text = Convert.ToString(resultadoSimplificado);
            }
          
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //Limpia cada textbox
            txt1.Text = ""; 
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txtTotal.Text = "";
            txtTotal2.Text = "";
            txtTotal3.Text = "";

            //devuelve el cursor al txt1
            txt1.Focus();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
