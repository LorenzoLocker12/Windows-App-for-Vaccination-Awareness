namespace LoginScreen
{
    partial class frmInfoVacinalGeral5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInfoVacinalGeral5));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack5 = new System.Windows.Forms.Button();
            this.btnNext5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(99, 49);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(205, 84);
            this.textBox1.TabIndex = 28;
            this.textBox1.Text = "E ao contrário do que muitos pensam a vacina não funciona como uma cura imediata," +
    " mas preparam o organismo para combater a doença de maneira mais rápida e eficaz" +
    ".";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(48, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 170);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack5
            // 
            this.btnBack5.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBack5.FlatAppearance.BorderSize = 0;
            this.btnBack5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack5.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack5.ForeColor = System.Drawing.Color.White;
            this.btnBack5.Location = new System.Drawing.Point(12, 405);
            this.btnBack5.Name = "btnBack5";
            this.btnBack5.Size = new System.Drawing.Size(236, 33);
            this.btnBack5.TabIndex = 26;
            this.btnBack5.Text = "VOLTAR";
            this.btnBack5.UseVisualStyleBackColor = false;
            this.btnBack5.Click += new System.EventHandler(this.btnBack5_Click);
            this.btnBack5.MouseLeave += new System.EventHandler(this.btnBack5_MouseLeave);
            this.btnBack5.MouseHover += new System.EventHandler(this.btnBack5_MouseHover);
            // 
            // btnNext5
            // 
            this.btnNext5.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnNext5.FlatAppearance.BorderSize = 0;
            this.btnNext5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext5.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext5.ForeColor = System.Drawing.Color.White;
            this.btnNext5.Location = new System.Drawing.Point(691, 405);
            this.btnNext5.Name = "btnNext5";
            this.btnNext5.Size = new System.Drawing.Size(236, 33);
            this.btnNext5.TabIndex = 25;
            this.btnNext5.Text = "PRÓXIMO";
            this.btnNext5.UseVisualStyleBackColor = false;
            this.btnNext5.Click += new System.EventHandler(this.btnNext5_Click);
            this.btnNext5.MouseLeave += new System.EventHandler(this.btnNext5_MouseLeave);
            this.btnNext5.MouseHover += new System.EventHandler(this.btnNext5_MouseHover);
            // 
            // frmInfoVacinalGeral5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(939, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBack5);
            this.Controls.Add(this.btnNext5);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInfoVacinalGeral5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informações Vacinais";
            this.Load += new System.EventHandler(this.frmInfoVacinalGeral5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBack5;
        private System.Windows.Forms.Button btnNext5;
    }
}