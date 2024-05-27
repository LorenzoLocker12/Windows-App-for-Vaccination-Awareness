namespace LoginScreen
{
    partial class frmInfoVacinalGeral4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInfoVacinalGeral4));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack4 = new System.Windows.Forms.Button();
            this.btnNext4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "A vacinação não apenas protege aqueles que recebem a vacina, mas também ajuda a c" +
    "omunidade como um todo.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(48, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 170);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack4
            // 
            this.btnBack4.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBack4.FlatAppearance.BorderSize = 0;
            this.btnBack4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack4.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack4.ForeColor = System.Drawing.Color.White;
            this.btnBack4.Location = new System.Drawing.Point(12, 405);
            this.btnBack4.Name = "btnBack4";
            this.btnBack4.Size = new System.Drawing.Size(236, 33);
            this.btnBack4.TabIndex = 22;
            this.btnBack4.Text = "VOLTAR";
            this.btnBack4.UseVisualStyleBackColor = false;
            this.btnBack4.Click += new System.EventHandler(this.btnBack4_Click);
            this.btnBack4.MouseLeave += new System.EventHandler(this.btnBack4_MouseLeave);
            this.btnBack4.MouseHover += new System.EventHandler(this.btnBack4_MouseHover);
            // 
            // btnNext4
            // 
            this.btnNext4.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnNext4.FlatAppearance.BorderSize = 0;
            this.btnNext4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext4.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext4.ForeColor = System.Drawing.Color.White;
            this.btnNext4.Location = new System.Drawing.Point(691, 405);
            this.btnNext4.Name = "btnNext4";
            this.btnNext4.Size = new System.Drawing.Size(236, 33);
            this.btnNext4.TabIndex = 21;
            this.btnNext4.Text = "PRÓXIMO";
            this.btnNext4.UseVisualStyleBackColor = false;
            this.btnNext4.Click += new System.EventHandler(this.btnNext4_Click);
            this.btnNext4.MouseLeave += new System.EventHandler(this.btnNext4_MouseLeave);
            this.btnNext4.MouseHover += new System.EventHandler(this.btnNext4_MouseHover);
            // 
            // frmInfoVacinalGeral4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(939, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBack4);
            this.Controls.Add(this.btnNext4);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInfoVacinalGeral4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informações Vacinais";
            this.Load += new System.EventHandler(this.frmInfoVacinalGeral4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBack4;
        private System.Windows.Forms.Button btnNext4;
    }
}