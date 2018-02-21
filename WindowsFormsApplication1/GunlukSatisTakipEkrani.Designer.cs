namespace WindowsFormsApplication1
{
    partial class GunlukSatisTakipEkrani
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
            this.txtGunlukSatisListele = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.lblGunlukSatisToplami = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGunlukSatisListele
            // 
            this.txtGunlukSatisListele.BackColor = System.Drawing.SystemColors.Menu;
            this.txtGunlukSatisListele.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGunlukSatisListele.Location = new System.Drawing.Point(12, 145);
            this.txtGunlukSatisListele.Multiline = true;
            this.txtGunlukSatisListele.Name = "txtGunlukSatisListele";
            this.txtGunlukSatisListele.Size = new System.Drawing.Size(760, 287);
            this.txtGunlukSatisListele.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources._76e022000px_MiGROS_Logo_svg;
            this.pictureBox2.Location = new System.Drawing.Point(219, 79);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(298, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.welc07;
            this.pictureBox1.Location = new System.Drawing.Point(296, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.Location = new System.Drawing.Point(453, 475);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(114, 21);
            this.lblToplamTutar.TabIndex = 25;
            this.lblToplamTutar.Text = "Toplam Tutar:";
            // 
            // lblGunlukSatisToplami
            // 
            this.lblGunlukSatisToplami.AutoSize = true;
            this.lblGunlukSatisToplami.BackColor = System.Drawing.SystemColors.Window;
            this.lblGunlukSatisToplami.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGunlukSatisToplami.ForeColor = System.Drawing.Color.Red;
            this.lblGunlukSatisToplami.Location = new System.Drawing.Point(573, 475);
            this.lblGunlukSatisToplami.Name = "lblGunlukSatisToplami";
            this.lblGunlukSatisToplami.Size = new System.Drawing.Size(0, 23);
            this.lblGunlukSatisToplami.TabIndex = 26;
            // 
            // GunlukSatisTakipEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblGunlukSatisToplami);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtGunlukSatisListele);
            this.Name = "GunlukSatisTakipEkrani";
            this.Text = "GunlukSatisTakipEkrani";
            this.Load += new System.EventHandler(this.GunlukSatisTakipEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGunlukSatisListele;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label lblGunlukSatisToplami;
    }
}