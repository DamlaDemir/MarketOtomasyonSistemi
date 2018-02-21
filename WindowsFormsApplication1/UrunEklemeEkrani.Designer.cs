namespace WindowsFormsApplication1
{
    partial class UrunEklemeEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunEklemeEkrani));
            this.ımageListUrunEkle = new System.Windows.Forms.ImageList(this.components);
            this.txtUrunTanimi = new System.Windows.Forms.TextBox();
            this.lblUrunBirimFiyati = new System.Windows.Forms.Label();
            this.lblUrunTanimi = new System.Windows.Forms.Label();
            this.txtUrunKodu = new System.Windows.Forms.TextBox();
            this.lblUrunKodu = new System.Windows.Forms.Label();
            this.txtUrunBirimFiyati = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.lblUrunMiktari = new System.Windows.Forms.Label();
            this.txtUrunMiktari = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageListUrunEkle
            // 
            this.ımageListUrunEkle.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListUrunEkle.ImageStream")));
            this.ımageListUrunEkle.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageListUrunEkle.Images.SetKeyName(0, "add-item-icon.png");
            // 
            // txtUrunTanimi
            // 
            this.txtUrunTanimi.BackColor = System.Drawing.SystemColors.Menu;
            this.txtUrunTanimi.Location = new System.Drawing.Point(429, 95);
            this.txtUrunTanimi.Multiline = true;
            this.txtUrunTanimi.Name = "txtUrunTanimi";
            this.txtUrunTanimi.Size = new System.Drawing.Size(181, 54);
            this.txtUrunTanimi.TabIndex = 4;
            // 
            // lblUrunBirimFiyati
            // 
            this.lblUrunBirimFiyati.AutoSize = true;
            this.lblUrunBirimFiyati.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunBirimFiyati.Location = new System.Drawing.Point(327, 172);
            this.lblUrunBirimFiyati.Name = "lblUrunBirimFiyati";
            this.lblUrunBirimFiyati.Size = new System.Drawing.Size(87, 19);
            this.lblUrunBirimFiyati.TabIndex = 5;
            this.lblUrunBirimFiyati.Text = "Ürün Fiyatı:";
            // 
            // lblUrunTanimi
            // 
            this.lblUrunTanimi.AutoSize = true;
            this.lblUrunTanimi.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunTanimi.Location = new System.Drawing.Point(327, 121);
            this.lblUrunTanimi.Name = "lblUrunTanimi";
            this.lblUrunTanimi.Size = new System.Drawing.Size(92, 19);
            this.lblUrunTanimi.TabIndex = 3;
            this.lblUrunTanimi.Text = "Ürün Tanımı:";
            // 
            // txtUrunKodu
            // 
            this.txtUrunKodu.BackColor = System.Drawing.SystemColors.Menu;
            this.txtUrunKodu.Location = new System.Drawing.Point(429, 51);
            this.txtUrunKodu.Name = "txtUrunKodu";
            this.txtUrunKodu.Size = new System.Drawing.Size(181, 20);
            this.txtUrunKodu.TabIndex = 2;
            // 
            // lblUrunKodu
            // 
            this.lblUrunKodu.AutoSize = true;
            this.lblUrunKodu.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunKodu.Location = new System.Drawing.Point(327, 52);
            this.lblUrunKodu.Name = "lblUrunKodu";
            this.lblUrunKodu.Size = new System.Drawing.Size(81, 19);
            this.lblUrunKodu.TabIndex = 1;
            this.lblUrunKodu.Text = "Ürün Kodu:";
            // 
            // txtUrunBirimFiyati
            // 
            this.txtUrunBirimFiyati.BackColor = System.Drawing.SystemColors.Menu;
            this.txtUrunBirimFiyati.Location = new System.Drawing.Point(429, 171);
            this.txtUrunBirimFiyati.Name = "txtUrunBirimFiyati";
            this.txtUrunBirimFiyati.Size = new System.Drawing.Size(181, 20);
            this.txtUrunBirimFiyati.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox3.Image = global::WindowsFormsApplication1.Properties.Resources.migros_12112015_kg;
            this.pictureBox3.Location = new System.Drawing.Point(33, 51);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(254, 254);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.BackColor = System.Drawing.SystemColors.Menu;
            this.btnUrunEkle.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunEkle.ImageKey = "add-item-icon.png";
            this.btnUrunEkle.ImageList = this.ımageListUrunEkle;
            this.btnUrunEkle.Location = new System.Drawing.Point(449, 282);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(144, 45);
            this.btnUrunEkle.TabIndex = 9;
            this.btnUrunEkle.Text = "EKLE";
            this.btnUrunEkle.UseVisualStyleBackColor = false;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // lblUrunMiktari
            // 
            this.lblUrunMiktari.AutoSize = true;
            this.lblUrunMiktari.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunMiktari.Location = new System.Drawing.Point(327, 231);
            this.lblUrunMiktari.Name = "lblUrunMiktari";
            this.lblUrunMiktari.Size = new System.Drawing.Size(96, 19);
            this.lblUrunMiktari.TabIndex = 7;
            this.lblUrunMiktari.Text = "Ürün Miktarı:";
            // 
            // txtUrunMiktari
            // 
            this.txtUrunMiktari.BackColor = System.Drawing.SystemColors.Menu;
            this.txtUrunMiktari.Location = new System.Drawing.Point(429, 231);
            this.txtUrunMiktari.Name = "txtUrunMiktari";
            this.txtUrunMiktari.Size = new System.Drawing.Size(181, 20);
            this.txtUrunMiktari.TabIndex = 8;
            // 
            // UrunEklemeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(657, 397);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtUrunMiktari);
            this.Controls.Add(this.lblUrunMiktari);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.txtUrunBirimFiyati);
            this.Controls.Add(this.lblUrunBirimFiyati);
            this.Controls.Add(this.txtUrunTanimi);
            this.Controls.Add(this.lblUrunTanimi);
            this.Controls.Add(this.txtUrunKodu);
            this.Controls.Add(this.lblUrunKodu);
            this.Name = "UrunEklemeEkrani";
            this.Text = "UrunEklemeEkrani";
            this.Load += new System.EventHandler(this.UrunEklemeEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList ımageListUrunEkle;
        private System.Windows.Forms.TextBox txtUrunTanimi;
        private System.Windows.Forms.Label lblUrunBirimFiyati;
        private System.Windows.Forms.Label lblUrunTanimi;
        private System.Windows.Forms.TextBox txtUrunKodu;
        private System.Windows.Forms.Label lblUrunKodu;
        private System.Windows.Forms.TextBox txtUrunBirimFiyati;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Label lblUrunMiktari;
        private System.Windows.Forms.TextBox txtUrunMiktari;
    }
}