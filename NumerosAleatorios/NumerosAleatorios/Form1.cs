using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NumerosAleatorios
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            Random rdn = new Random();
            int a = rdn.Next(1, 100);
            textBox1.Text = a.ToString();


            
            

            


            
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            this.progressBar1.Increment(1);
            progressBar1.Value = int.Parse(textBox1.Text);
                vScrollBar1.Value = int.Parse(textBox1.Text);
                hScrollBar1.Value = int.Parse(textBox1.Text);
            
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.Text = vScrollBar1.Value.ToString();
            
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.Text = hScrollBar1.Value.ToString();
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }
    

    }
}
