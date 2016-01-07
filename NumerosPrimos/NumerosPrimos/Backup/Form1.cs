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

        // Find the number's factors.
        private void btnFactor_Click(object sender, EventArgs e)
        {
            txtFactors.Clear();
            Refresh();

            // Get the number.
            long number;
            if (!long.TryParse(txtNumber.Text, out number)) number = -1;
            if (number < 2)
            {
                MessageBox.Show("The number must be between 2 and " +
                    long.MaxValue);
                txtFactors.Focus();
                return;
            }

            // Get the factors.
            List<long> factors = FindFactors(number);
            List<string> strings = factors.ConvertAll<string>(x => x.ToString());
            txtFactors.Text = string.Join(" x ", strings.ToArray());
        }

        // Return the number's prime factors.
        private List<long> FindFactors(long num)
        {
            List<long> result = new List<long>();

            // Take out the 2s.
            while (num % 2 == 0)
            {
                result.Add(2);
                num /= 2;
            }

            // Take out other primes.
            long factor = 3;
            while (factor * factor <= num)
            {
                if (num % factor == 0)
                {
                    // This is a factor.
                    result.Add(factor);
                    num /= factor;
                }
                else
                {
                    // Go to the next odd number.
                    factor += 2;
                }
            }

            // If num is not 1, then whatever is left is prime.
            if (num > 1) result.Add(num);

            return result;
        }
    }
}
