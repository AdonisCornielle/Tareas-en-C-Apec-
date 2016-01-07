namespace BackGroundWorkSample
{
    partial class frmBackGround
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackGround));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtE = new System.Windows.Forms.TextBox();
            this.txtI = new System.Windows.Forms.TextBox();
            this.txtO = new System.Windows.Forms.TextBox();
            this.txtU = new System.Windows.Forms.TextBox();
            this.ProgressB = new System.Windows.Forms.ProgressBar();
            this.chkUseBackground = new System.Windows.Forms.CheckBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkUseDoevents = new System.Windows.Forms.CheckBox();
            this.BckThread = new System.ComponentModel.BackgroundWorker();
            this.lblEvtComplete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "A ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "E";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(184, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "I";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(256, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "O";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(333, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "U";
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.ForeColor = System.Drawing.Color.Maroon;
            this.txtA.Location = new System.Drawing.Point(6, 346);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(56, 27);
            this.txtA.TabIndex = 5;
            this.txtA.Text = "0";
            // 
            // txtE
            // 
            this.txtE.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtE.ForeColor = System.Drawing.Color.Maroon;
            this.txtE.Location = new System.Drawing.Point(94, 346);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(56, 27);
            this.txtE.TabIndex = 6;
            this.txtE.Text = "0";
            // 
            // txtI
            // 
            this.txtI.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtI.ForeColor = System.Drawing.Color.Maroon;
            this.txtI.Location = new System.Drawing.Point(168, 346);
            this.txtI.Name = "txtI";
            this.txtI.Size = new System.Drawing.Size(56, 27);
            this.txtI.TabIndex = 7;
            this.txtI.Text = "0";
            // 
            // txtO
            // 
            this.txtO.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtO.ForeColor = System.Drawing.Color.Maroon;
            this.txtO.Location = new System.Drawing.Point(245, 346);
            this.txtO.Name = "txtO";
            this.txtO.Size = new System.Drawing.Size(56, 27);
            this.txtO.TabIndex = 8;
            this.txtO.Text = "0";
            // 
            // txtU
            // 
            this.txtU.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtU.ForeColor = System.Drawing.Color.Maroon;
            this.txtU.Location = new System.Drawing.Point(319, 346);
            this.txtU.Name = "txtU";
            this.txtU.Size = new System.Drawing.Size(56, 27);
            this.txtU.TabIndex = 9;
            this.txtU.Text = "0";
            // 
            // ProgressB
            // 
            this.ProgressB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ProgressB.Location = new System.Drawing.Point(6, 379);
            this.ProgressB.Name = "ProgressB";
            this.ProgressB.Size = new System.Drawing.Size(369, 23);
            this.ProgressB.TabIndex = 10;
            // 
            // chkUseBackground
            // 
            this.chkUseBackground.AutoSize = true;
            this.chkUseBackground.Font = new System.Drawing.Font("Verdana", 7.841584F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUseBackground.Location = new System.Drawing.Point(8, 3);
            this.chkUseBackground.Name = "chkUseBackground";
            this.chkUseBackground.Size = new System.Drawing.Size(169, 17);
            this.chkUseBackground.TabIndex = 11;
            this.chkUseBackground.Text = "Usar Background Worker";
            this.chkUseBackground.UseVisualStyleBackColor = true;
            this.chkUseBackground.Visible = false;
            this.chkUseBackground.Click += new System.EventHandler(this.chkUseBackground_Click);
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(6, 102);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(364, 215);
            this.txtContent.TabIndex = 12;
            this.txtContent.Text = resources.GetString("txtContent.Text");
            this.txtContent.TextChanged += new System.EventHandler(this.txtContent_TextChanged);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnStart.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(6, 22);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(182, 36);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "INICIAR CONTEO";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(197, 22);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(182, 36);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "DETENER";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkUseDoevents
            // 
            this.chkUseDoevents.AutoSize = true;
            this.chkUseDoevents.Checked = true;
            this.chkUseDoevents.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseDoevents.Font = new System.Drawing.Font("Verdana", 7.841584F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUseDoevents.Location = new System.Drawing.Point(269, 3);
            this.chkUseDoevents.Name = "chkUseDoevents";
            this.chkUseDoevents.Size = new System.Drawing.Size(110, 17);
            this.chkUseDoevents.TabIndex = 15;
            this.chkUseDoevents.Text = "Usar DoEvents";
            this.chkUseDoevents.UseVisualStyleBackColor = true;
            this.chkUseDoevents.Visible = false;
            // 
            // BckThread
            // 
            this.BckThread.WorkerReportsProgress = true;
            this.BckThread.WorkerSupportsCancellation = true;
            this.BckThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BckThread_DoWork);
            this.BckThread.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BckThread_ProgressChanged);
            this.BckThread.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BckThread_RunWorkerCompleted);
            // 
            // lblEvtComplete
            // 
            this.lblEvtComplete.AutoSize = true;
            this.lblEvtComplete.Font = new System.Drawing.Font("Arial Narrow", 14.25743F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvtComplete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblEvtComplete.Location = new System.Drawing.Point(6, 61);
            this.lblEvtComplete.Name = "lblEvtComplete";
            this.lblEvtComplete.Size = new System.Drawing.Size(0, 24);
            this.lblEvtComplete.TabIndex = 16;
            // 
            // frmBackGround
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(379, 414);
            this.Controls.Add(this.lblEvtComplete);
            this.Controls.Add(this.chkUseDoevents);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.chkUseBackground);
            this.Controls.Add(this.ProgressB);
            this.Controls.Add(this.txtU);
            this.Controls.Add(this.txtO);
            this.Controls.Add(this.txtI);
            this.Controls.Add(this.txtE);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBackGround";
            this.Text = "CONTADOR DE VOCALES";
            this.Load += new System.EventHandler(this.frmBackGround_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.TextBox txtI;
        private System.Windows.Forms.TextBox txtO;
        private System.Windows.Forms.TextBox txtU;
        private System.Windows.Forms.ProgressBar ProgressB;
        private System.Windows.Forms.CheckBox chkUseBackground;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkUseDoevents;
        private System.ComponentModel.BackgroundWorker BckThread;
        private System.Windows.Forms.Label lblEvtComplete;
    }
}

