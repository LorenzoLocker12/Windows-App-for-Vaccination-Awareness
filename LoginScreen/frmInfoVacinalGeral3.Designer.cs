namespace LoginScreen
{
    partial class frmInfoVacinalGeral3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInfoVacinalGeral3));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack3 = new System.Windows.Forms.Button();
            this.btnNext3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(71, 45);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(205, 80);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "As vacinas protegem o corpo humano contra os vírus e bactérias, que provocam vári" +
    "os tipos de doenças graves. Que podem afetar seriamente a saúde das pessoas e in" +
    "clusive levá-las à morte.";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(28, -149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 498);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack3
            // 
            this.btnBack3.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBack3.FlatAppearance.BorderSize = 0;
            this.btnBack3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack3.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack3.ForeColor = System.Drawing.Color.White;
            this.btnBack3.Location = new System.Drawing.Point(10, 405);
            this.btnBack3.Name = "btnBack3";
            this.btnBack3.Size = new System.Drawing.Size(236, 33);
            this.btnBack3.TabIndex = 22;
            this.btnBack3.Text = "VOLTAR";
            this.btnBack3.UseVisualStyleBackColor = false;
            this.btnBack3.Click += new System.EventHandler(this.btnBack3_Click);
            this.btnBack3.MouseLeave += new System.EventHandler(this.btnBack3_MouseLeave);
            this.btnBack3.MouseHover += new System.EventHandler(this.btnBack3_MouseHover);
            // 
            // btnNext3
            // 
            this.btnNext3.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnNext3.FlatAppearance.BorderSize = 0;
            this.btnNext3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext3.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext3.ForeColor = System.Drawing.Color.White;
            this.btnNext3.Location = new System.Drawing.Point(689, 405);
            this.btnNext3.Name = "btnNext3";
            this.btnNext3.Size = new System.Drawing.Size(236, 33);
            this.btnNext3.TabIndex = 21;
            this.btnNext3.Text = "PRÓXIMO";
            this.btnNext3.UseVisualStyleBackColor = false;
            this.btnNext3.Click += new System.EventHandler(this.btnNext3_Click);
            this.btnNext3.MouseLeave += new System.EventHandler(this.btnNext3_MouseLeave);
            this.btnNext3.MouseHover += new System.EventHandler(this.btnNext3_MouseHover);
            // 
            // frmInfoVacinalGeral3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(939, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBack3);
            this.Controls.Add(this.btnNext3);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInfoVacinalGeral3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informações Vacinais";
            this.Load += new System.EventHandler(this.frmInfoVacinalGeral3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBack3;
        private System.Windows.Forms.Button btnNext3;
    }
}