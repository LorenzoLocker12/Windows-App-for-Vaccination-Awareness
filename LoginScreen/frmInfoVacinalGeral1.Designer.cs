namespace LoginScreen
{
    partial class frmInfoVacinalGeral1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInfoVacinalGeral1));
            this.btnNext1 = new System.Windows.Forms.Button();
            this.btnBack1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNext1
            // 
            this.btnNext1.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnNext1.FlatAppearance.BorderSize = 0;
            this.btnNext1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext1.ForeColor = System.Drawing.Color.White;
            this.btnNext1.Location = new System.Drawing.Point(691, 405);
            this.btnNext1.Name = "btnNext1";
            this.btnNext1.Size = new System.Drawing.Size(236, 33);
            this.btnNext1.TabIndex = 17;
            this.btnNext1.Text = "PRÓXIMO";
            this.btnNext1.UseVisualStyleBackColor = false;
            this.btnNext1.Click += new System.EventHandler(this.btnNext1_Click);
            this.btnNext1.MouseLeave += new System.EventHandler(this.btnNext1_MouseLeave);
            this.btnNext1.MouseHover += new System.EventHandler(this.btnNext1_MouseHover);
            // 
            // btnBack1
            // 
            this.btnBack1.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBack1.FlatAppearance.BorderSize = 0;
            this.btnBack1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack1.ForeColor = System.Drawing.Color.White;
            this.btnBack1.Location = new System.Drawing.Point(12, 405);
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Size = new System.Drawing.Size(236, 33);
            this.btnBack1.TabIndex = 18;
            this.btnBack1.Text = "VOLTAR";
            this.btnBack1.UseVisualStyleBackColor = false;
            this.btnBack1.Click += new System.EventHandler(this.btnBack1_Click);
            this.btnBack1.MouseLeave += new System.EventHandler(this.btnBack1_MouseLeave);
            this.btnBack1.MouseHover += new System.EventHandler(this.btnBack1_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(48, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 170);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(99, 49);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(205, 84);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "Olá, eu sou a Bia. Sou formada em medicina. E, através deste programa irei inform" +
    "ar sobre as vacinas e sua importância!";
            // 
            // frmInfoVacinalGeral1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(939, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBack1);
            this.Controls.Add(this.btnNext1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInfoVacinalGeral1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informações Vacinais";
            this.Load += new System.EventHandler(this.frmInfoVacinalGeral1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext1;
        private System.Windows.Forms.Button btnBack1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}