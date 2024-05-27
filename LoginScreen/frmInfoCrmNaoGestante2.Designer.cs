namespace LoginScreen
{
    partial class frmInfoCrmNaoGestante2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInfoCrmNaoGestante2));
            this.btnBack2 = new System.Windows.Forms.Button();
            this.btnNext2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack2
            // 
            this.btnBack2.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBack2.FlatAppearance.BorderSize = 0;
            this.btnBack2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack2.ForeColor = System.Drawing.Color.White;
            this.btnBack2.Location = new System.Drawing.Point(12, 443);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.Size = new System.Drawing.Size(492, 33);
            this.btnBack2.TabIndex = 31;
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
            this.btnNext2.Location = new System.Drawing.Point(727, 443);
            this.btnNext2.Name = "btnNext2";
            this.btnNext2.Size = new System.Drawing.Size(492, 33);
            this.btnNext2.TabIndex = 30;
            this.btnNext2.Text = "PRÓXIMO";
            this.btnNext2.UseVisualStyleBackColor = false;
            this.btnNext2.Click += new System.EventHandler(this.btnNext2_Click);
            this.btnNext2.MouseLeave += new System.EventHandler(this.btnNext2_MouseLeave);
            this.btnNext2.MouseHover += new System.EventHandler(this.btnNext2_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1207, 409);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // frmInfoCrmNaoGestante2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 492);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBack2);
            this.Controls.Add(this.btnNext2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInfoCrmNaoGestante2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informações Vacinais Não Gestante";
            this.Load += new System.EventHandler(this.frmInfoCrmNaoGestante2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBack2;
        private System.Windows.Forms.Button btnNext2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}