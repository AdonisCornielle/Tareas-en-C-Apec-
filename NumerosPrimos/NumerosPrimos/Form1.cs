using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace howto_list_prime_factors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Encuentra los factores de los numeros.
        private void btnFactor_Click(object sender, EventArgs e)
        {
            txtFactors.Clear();
           
            Refresh();

            // Toma el numero.
            long number;
            if (!long.TryParse(txtNumber.Text, out number)) number = -1;
            if (number < 2)
            {
                MessageBox.Show("The number must be between 2 and " +
                    long.MaxValue);
                txtFactors.Focus();
                
                return;
            }

            // Toma los factores.
            List<long> factors = FindFactors(number);
            List<string> strings = factors.ConvertAll<string>(x => x.ToString());
            txtFactors.Text = string.Join(" x ", strings.ToArray());
            listBox1.Items.Add(txtFactors.Text);
           
            

        }


        // Devuelve los factores primos del numero.
        private List<long> FindFactors(long num)
        {
            List<long> result = new List<long>();

            // Saca las mitades.
            while (num % 2 == 0)
            {
                result.Add(2);
                num /= 2;
            }

            // Saca los primos.
            long factor = 3;
            while (factor * factor <= num)
            {
                if (num % factor == 0)
                {
                    // Este es el factor.
                    result.Add(factor);
                    num /= factor;
                }
                else
                {
                    // Va al siguiente numero impar.
                    factor += 2;
                }
            }

            // Si este no es 1, entonces los que queden son primos.
            if (num > 1) result.Add(num);

            return result;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtFactors_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
