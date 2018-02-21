namespace WindowsFormsApplication1
{
    partial class LoginEkrani
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.pictureBoxResim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResim)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(40, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.ForeColor = System.Drawing.Color.Black;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(154, 150);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(151, 20);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(154, 192);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(151, 20);
            this.txtParola.TabIndex = 3;
            this.txtParola.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(40, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parola:";
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGiris.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGiris.Location = new System.Drawing.Point(154, 240);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(151, 32);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "GİRİŞ";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // pictureBoxResim
            // 
            this.pictureBoxResim.Image = global::WindowsFormsApplication1.Properties.Resources.migrosLogo;
            this.pictureBoxResim.Location = new System.Drawing.Point(26, 28);
            this.pictureBoxResim.Name = "pictureBoxResim";
            this.pictureBoxResim.Size = new System.Drawing.Size(301, 89);
            this.pictureBoxResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxResim.TabIndex = 5;
            this.pictureBoxResim.TabStop = false;
            // 
            // LoginEkrani
            // 
            this.AcceptButton = this.btnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(374, 331);
            this.Controls.Add(this.pictureBoxResim);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "LoginEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginEkrani";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.PictureBox pictureBoxResim;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
    }
}

