namespace WindowsFormsApplication1
{
    partial class KasiyerAramaEkrani
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KasiyerAramaEkrani));
            this.btnKasiyerAra = new System.Windows.Forms.Button();
            this.ımageListKasiyerAra = new System.Windows.Forms.ImageList(this.components);
            this.txtAranacakKasiyerAdSoyad = new System.Windows.Forms.TextBox();
            this.lblAranacakKasiyerAdSoyad = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBulunanKasiyer = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKasiyerAra
            // 
            this.btnKasiyerAra.BackColor = System.Drawing.SystemColors.Menu;
            this.btnKasiyerAra.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKasiyerAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKasiyerAra.ImageKey = "Female-user-search-icon.png";
            this.btnKasiyerAra.ImageList = this.ımageListKasiyerAra;
            this.btnKasiyerAra.Location = new System.Drawing.Point(430, 192);
            this.btnKasiyerAra.Name = "btnKasiyerAra";
            this.btnKasiyerAra.Size = new System.Drawing.Size(145, 39);
            this.btnKasiyerAra.TabIndex = 18;
            this.btnKasiyerAra.Text = "ARA";
            this.btnKasiyerAra.UseVisualStyleBackColor = false;
            this.btnKasiyerAra.Click += new System.EventHandler(this.btnKasiyerAra_Click);
            // 
            // ımageListKasiyerAra
            // 
            this.ımageListKasiyerAra.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListKasiyerAra.ImageStream")));
            this.ımageListKasiyerAra.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageListKasiyerAra.Images.SetKeyName(0, "Female-user-search-icon.png");
            // 
            // txtAranacakKasiyerAdSoyad
            // 
            this.txtAranacakKasiyerAdSoyad.Location = new System.Drawing.Point(267, 198);
            this.txtAranacakKasiyerAdSoyad.Multiline = true;
            this.txtAranacakKasiyerAdSoyad.Name = "txtAranacakKasiyerAdSoyad";
            this.txtAranacakKasiyerAdSoyad.Size = new System.Drawing.Size(144, 23);
            this.txtAranacakKasiyerAdSoyad.TabIndex = 17;
            // 
            // lblAranacakKasiyerAdSoyad
            // 
            this.lblAranacakKasiyerAdSoyad.AutoSize = true;
            this.lblAranacakKasiyerAdSoyad.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAranacakKasiyerAdSoyad.Location = new System.Drawing.Point(190, 203);
            this.lblAranacakKasiyerAdSoyad.Name = "lblAranacakKasiyerAdSoyad";
            this.lblAranacakKasiyerAdSoyad.Size = new System.Drawing.Size(71, 18);
            this.lblAranacakKasiyerAdSoyad.TabIndex = 16;
            this.lblAranacakKasiyerAdSoyad.Text = "Ad Soyad:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources._76e022000px_MiGROS_Logo_svg;
            this.pictureBox2.Location = new System.Drawing.Point(226, 98);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(298, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.welc07;
            this.pictureBox1.Location = new System.Drawing.Point(303, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // txtBulunanKasiyer
            // 
            this.txtBulunanKasiyer.Location = new System.Drawing.Point(120, 272);
            this.txtBulunanKasiyer.Multiline = true;
            this.txtBulunanKasiyer.Name = "txtBulunanKasiyer";
            this.txtBulunanKasiyer.Size = new System.Drawing.Size(536, 152);
            this.txtBulunanKasiyer.TabIndex = 43;
            // 
            // KasiyerAramaEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.txtBulunanKasiyer);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnKasiyerAra);
            this.Controls.Add(this.txtAranacakKasiyerAdSoyad);
            this.Controls.Add(this.lblAranacakKasiyerAdSoyad);
            this.Name = "KasiyerAramaEkrani";
            this.Text = "KasiyerAramaEkrani";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKasiyerAra;
        private System.Windows.Forms.TextBox txtAranacakKasiyerAdSoyad;
        private System.Windows.Forms.Label lblAranacakKasiyerAdSoyad;
        private System.Windows.Forms.ImageList ımageListKasiyerAra;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBulunanKasiyer;
    }
}