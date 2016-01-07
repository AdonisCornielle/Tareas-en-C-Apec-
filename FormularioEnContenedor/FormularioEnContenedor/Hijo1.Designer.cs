namespace FormularioEnContenedor
{
    partial class Hijo1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btMostrarHijo2 = new System.Windows.Forms.Button();
            this.btMostrarHijo1 = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btMostrarHijo2
            // 
            this.btMostrarHijo2.Location = new System.Drawing.Point(12, 61);
            this.btMostrarHijo2.Name = "btMostrarHijo2";
            this.btMostrarHijo2.Size = new System.Drawing.Size(133, 60);
            this.btMostrarHijo2.TabIndex = 2;
            this.btMostrarHijo2.Text = "Mostrar Formulario En Panel";
            this.btMostrarHijo2.UseVisualStyleBackColor = true;
            this.btMostrarHijo2.Click += new System.EventHandler(this.btMostrarHijo2_Click);
            // 
            // btMostrarHijo1
            // 
            this.btMostrarHijo1.Location = new System.Drawing.Point(12, 180);
            this.btMostrarHijo1.Name = "btMostrarHijo1";
            this.btMostrarHijo1.Size = new System.Drawing.Size(133, 23);
            this.btMostrarHijo1.TabIndex = 3;
            this.btMostrarHijo1.Text = "Mostrar Hijo 1";
            this.btMostrarHijo1.UseVisualStyleBackColor = true;
            this.btMostrarHijo1.Visible = false;
            this.btMostrarHijo1.Click += new System.EventHandler(this.btMostrarHijo1_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Location = new System.Drawing.Point(182, 12);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(375, 290);
            this.panelContenedor.TabIndex = 4;
            // 
            // Hijo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(569, 314);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.btMostrarHijo1);
            this.Controls.Add(this.btMostrarHijo2);
            this.Name = "Hijo1";
            this.Text = "FORMULARIO EN CONTENEDOR";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btMostrarHijo2;
        private System.Windows.Forms.Button btMostrarHijo1;
        private System.Windows.Forms.Panel panelContenedor;
    }
}

