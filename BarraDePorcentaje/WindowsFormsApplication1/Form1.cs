using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int segundos;
        public Form1()
        {
            InitializeComponent();

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            this.timer2.Start();
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);

            textBox1.Text = progressBar1.Value.ToString();
            textBox1.AppendText(" %");
            
           

            

        }
  
            
        private void button2_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
            this.timer2.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            segundos = 0;
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            segundos = segundos + 1;
            if (segundos == 60)
                timer2.Stop();


            textBox2.Text = segundos.ToString();
            textBox2.AppendText(" Segundos");

            

        }

        
    }
}
