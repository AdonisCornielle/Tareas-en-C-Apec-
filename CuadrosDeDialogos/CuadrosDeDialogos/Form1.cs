using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CuadrosDeDialogos
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
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current text color.
            MyDialog.Color = textBox1.ForeColor;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
                textBox1.ForeColor = MyDialog.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //
            // This event handler was created by double-clicking the window in the designer.
            // It runs on the program's startup routine.
            //
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                //
                // The user selected a folder and pressed the OK button.
                // We print the number of files found.
                //
                string[] files = Directory.GetFiles(folderBrowserDialog1.SelectedPath);
                MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;

            fontDialog1.Font = textBox1.Font;
            fontDialog1.Color = textBox1.ForeColor;

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                textBox1.Font = fontDialog1.Font;
                textBox1.ForeColor = fontDialog1.Color;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // Insert code to read the stream here.
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        
{
   // Displays a SaveFileDialog so the user can save the Image
   // assigned to Button2.
   SaveFileDialog saveFileDialog1 = new SaveFileDialog();
   saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
   saveFileDialog1.Title = "Save an Image File";
   saveFileDialog1.ShowDialog();

   // If the file name is not an empty string open it for saving.
   if(saveFileDialog1.FileName != "")
   {
      // Saves the Image via a FileStream created by the OpenFile method.
      System.IO.FileStream fs = 
         (System.IO.FileStream)saveFileDialog1.OpenFile();
      // Saves the Image in the appropriate ImageFormat based upon the
      // File type selected in the dialog box.
      // NOTE that the FilterIndex property is one-based.
      switch(saveFileDialog1.FilterIndex)
      {
         case 1 : 
         this.button2.Image.Save(fs, 
            System.Drawing.Imaging.ImageFormat.Jpeg);
         break;

         case 2 : 
         this.button2.Image.Save(fs, 
            System.Drawing.Imaging.ImageFormat.Bmp);
         break;

         case 3 : 
         this.button2.Image.Save(fs, 
            System.Drawing.Imaging.ImageFormat.Gif);
         break;
      }

   fs.Close();
   }
}

    }
}
