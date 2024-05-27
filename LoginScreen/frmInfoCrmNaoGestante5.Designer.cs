namespace LoginScreen
{
    partial class frmInfoCrmNaoGestante5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInfoCrmNaoGestante5));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack2 = new System.Windows.Forms.Button();
            this.btnNext2 = new System.Windows.Forms.Button();
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
            this.textBox1.TabIndex = 36;
            this.textBox1.Text = "Nunca se esqueça de procurar saber sobre os efeitos colaterais das vacinas e se é" +
    " alérgico a alguma substancia.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(48, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 170);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack2
            // 
            this.btnBack2.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBack2.FlatAppearance.BorderSize = 0;
            this.btnBack2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack2.ForeColor = System.Drawing.Color.White;
            this.btnBack2.Location = new System.Drawing.Point(12, 405);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.Size = new System.Drawing.Size(236, 33);
            this.btnBack2.TabIndex = 34;
            this.btnBack2.Text = "VOLTAR";
            this.btnBack2.UseVisualStyleBackColor = false;
            this.btnBack2.Click += new System.EventHandler(this.btnBack2_Click);
            this.btnBack2.MouseLeave += new System.EventHandler(this.btnBack2_MouseLeave);
            this.btnBack2.MouseHover += new System.EventHandler(this.btnBack2_MouseHover);
            // 
            // btnNext2
            // 
            this.btnNext2.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnNext2.FlatAppearance.BorderSize = 0;
            this.btnNext2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext2.ForeColor = System.Drawing.Color.White;
            this.btnNext2.Location = new System.Drawing.Point(691, 405);
            this.btnNext2.Name = "btnNext2";
            this.btnNext2.Size = new System.Drawing.Size(236, 33);
            this.btnNext2.TabIndex = 33;
            this.btnNext2.Text = "PRÓXIMO";
            this.btnNext2.UseVisualStyleBackColor = false;
            this.btnNext2.Click += new System.EventHandler(this.btnNext2_Click);
            this.btnNext2.MouseLeave += new System.EventHandler(this.btnNext2_MouseLeave);
            this.btnNext2.MouseHover += new System.EventHandler(this.btnNext2_MouseHover);
            // 
            // frmInfoCrmNaoGestante5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(939, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBack2);
            this.Controls.Add(this.btnNext2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInfoCrmNaoGestante5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nunca se esqueça de procurar saber sobre os efeitos colaterais das vacinas e se é" +
    " alérgico a alguma substancia.";
            this.Load += new System.EventHandler(this.frmInfoCrmNaoGestante5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBack2;
        private System.Windows.Forms.Button btnNext2;
    }
}