using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioEnContenedor
{
    public partial class Hijo1 : Form
    {
        public Hijo1()
        {
            InitializeComponent();
        }

        private void AddFormInPanel(Form fh)
{
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);            
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
} 

        private void btMostrarHijo1_Click(object sender, EventArgs e)
        {
             if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Hijo1 form = Application.OpenForms.OfType<Hijo1>().FirstOrDefault();
            Hijo1 hijo1 = form ?? new Hijo1();
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(hijo1);
            this.panelContenedor.Tag = hijo1;
            hijo1.Show();
        }

        private void btMostrarHijo2_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<Hijo2>().FirstOrDefault();
            Hijo2 hijo = form ?? new Hijo2();
            AddFormInPanel(hijo);
        }
    }

}
