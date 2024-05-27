namespace LoginScreen
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.painelinfo = new System.Windows.Forms.Panel();
            this.sair = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.cmbGestante_Required = new System.Windows.Forms.ComboBox();
            this.txtUserName_Required = new System.Windows.Forms.TextBox();
            this.txtGestanteInfo = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.painelinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(30, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "INFORMAÇÕES";
            // 
            // painelinfo
            // 
            this.painelinfo.BackColor = System.Drawing.Color.Transparent;
            this.painelinfo.Controls.Add(this.sair);
            this.painelinfo.Controls.Add(this.btnNext);
            this.painelinfo.Controls.Add(this.cmbGestante_Required);
            this.painelinfo.Controls.Add(this.txtUserName_Required);
            this.painelinfo.Controls.Add(this.txtGestanteInfo);
            this.painelinfo.Controls.Add(this.nome);
            this.painelinfo.Controls.Add(this.panel2);
            this.painelinfo.Controls.Add(this.panel1);
            this.painelinfo.Controls.Add(this.pictureBox3);
            this.painelinfo.Controls.Add(this.pictureBox2);
            this.painelinfo.Location = new System.Drawing.Point(13, 182);
            this.painelinfo.Name = "painelinfo";
            this.painelinfo.Size = new System.Drawing.Size(267, 253);
            this.painelinfo.TabIndex = 8;
            // 
            // sair
            // 
            this.sair.AutoSize = true;
            this.sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.sair.Location = new System.Drawing.Point(108, 217);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(42, 16);
            this.sair.TabIndex = 17;
            this.sair.Text = "SAIR";
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(17, 171);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(236, 33);
            this.btnNext.TabIndex = 16;
            this.btnNext.Text = "PRÓXIMO";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.MouseLeave += new System.EventHandler(this.btnNext_MouseLeave);
            this.btnNext.MouseHover += new System.EventHandler(this.btnNext_MouseHover);
            // 
            // cmbGestante_Required
            // 
            this.cmbGestante_Required.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGestante_Required.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.cmbGestante_Required.FormattingEnabled = true;
            this.cmbGestante_Required.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbGestante_Required.Items.AddRange(new object[] {
            "SIM",
            "NÃO"});
            this.cmbGestante_Required.Location = new System.Drawing.Point(49, 103);
            this.cmbGestante_Required.Name = "cmbGestante_Required";
            this.cmbGestante_Required.Size = new System.Drawing.Size(121, 21);
            this.cmbGestante_Required.TabIndex = 15;
            // 
            // txtUserName_Required
            // 
            this.txtUserName_Required.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName_Required.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName_Required.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.txtUserName_Required.Location = new System.Drawing.Point(49, 35);
            this.txtUserName_Required.Multiline = true;
            this.txtUserName_Required.Name = "txtUserName_Required";
            this.txtUserName_Required.Size = new System.Drawing.Size(204, 24);
            this.txtUserName_Required.TabIndex = 14;
            // 
            // txtGestanteInfo
            // 
            this.txtGestanteInfo.AutoSize = true;
            this.txtGestanteInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGestanteInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.txtGestanteInfo.Location = new System.Drawing.Point(14, 84);
            this.txtGestanteInfo.Name = "txtGestanteInfo";
            this.txtGestanteInfo.Size = new System.Drawing.Size(77, 16);
            this.txtGestanteInfo.TabIndex = 12;
            this.txtGestanteInfo.Text = "Gestante: ";
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.nome.Location = new System.Drawing.Point(14, 12);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(56, 16);
            this.nome.TabIndex = 12;
            this.nome.Text = "Nome: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel2.Location = new System.Drawing.Point(17, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 1);
            this.panel2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel1.Location = new System.Drawing.Point(17, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 1);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(17, 103);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(17, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(101, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(292, 447);
            this.Controls.Add(this.painelinfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.painelinfo.ResumeLayout(false);
            this.painelinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel painelinfo;
        private System.Windows.Forms.Label sair;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ComboBox cmbGestante_Required;
        private System.Windows.Forms.TextBox txtUserName_Required;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label txtGestanteInfo;
    }
}

