using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDeDialogo
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

        private void btnColor_Click_1(object sender, EventArgs e)
        {
ColorDialog MyDialog = new ColorDialog();
// Keeps the user from selecting a custom color.
MyDialog.AllowFullOpen = false;
// Allows the user to get help. (The default is false.)
MyDialog.ShowHelp = true;
// Sets the initial color select to the current text color.
MyDialog.Color = txtColor.ForeColor;
// Update the text box color if the user clicks OK
if (MyDialog.ShowDialog() == DialogResult.OK)
txtColor.ForeColor = MyDialog.Color;
}

private void btnFont_Click_1(object sender, EventArgs e)
        {
fontDialog1.ShowColor = true;
fontDialog1.Font = txtColor.Font;
fontDialog1.Color = txtColor.ForeColor;
if (fontDialog1.ShowDialog() != DialogResult.Cancel)
{
txtColor.Font = fontDialog1.Font;
txtColor.ForeColor = fontDialog1.Color;
}
}



private void btnOpen_Click_1(object sender, EventArgs e)
        {
string foto;
//Definimos los filtros de archivos a permitir, en este caso imagenes
openFileDialog1.Filter = "Bitmap files (*.bmp)|*.bmp|Gif files (*.gif)|*.gif|JGP files(*.jpg)|*.jpg|All (*.*)|*.* |PNG (*.paisaje)|*.png";
//Establece que filtro se mostrará por defecto en este caso, 3=jpg
openFileDialog1.FilterIndex = 3;
//Esto aparece en el Nombre del archivo a seleccionar, se puede quitar no es fundamental
openFileDialog1.FileName="Seleccione una imagen";
//El titulo de la Ventana....
openFileDialog1.Title = "paisaje)";
//El directorio que por defecto abrirá, para cada contrapleca del Path colocar \\

openFileDialog1.InitialDirectory = "c:\\paisaje";
/// Evalúa que si al aparecer el cuadro de dialogo la persona presionó Ok
if (openFileDialog1.ShowDialog() == DialogResult.OK)
{
/// Si esto se cumple, capturamos la propiedad File Name y la guardamos en la variable foto
foto = openFileDialog1.FileName;
//Por ultimo se la asignamos al PictureBox
 pctImagen.Image = Image.FromFile(@foto);
        }
}

        
}
}