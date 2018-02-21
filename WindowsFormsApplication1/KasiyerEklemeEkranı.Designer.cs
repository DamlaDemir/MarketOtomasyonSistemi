namespace WindowsFormsApplication1
{
    partial class KasiyerEklemeEkranı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KasiyerEklemeEkranı));
            this.ımageListKasiyerEkle = new System.Windows.Forms.ImageList(this.components);
            this.btnKasiyerEkle = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbKasaNo = new System.Windows.Forms.ComboBox();
            this.lblKasaNo = new System.Windows.Forms.Label();
            this.txtKasiyerParola = new System.Windows.Forms.TextBox();
            this.lblKasiyerParola = new System.Windows.Forms.Label();
            this.txtKasiyerTcNo = new System.Windows.Forms.TextBox();
            this.lblKasiyerTcNo = new System.Windows.Forms.Label();
            this.rbKasiyerKadin = new System.Windows.Forms.RadioButton();
            this.rbKasiyerErkek = new System.Windows.Forms.RadioButton();
            this.lblKasiyerCinsiyet = new System.Windows.Forms.Label();
            this.txtKasiyerEmailAdresi = new System.Windows.Forms.TextBox();
            this.lblKasiyerEmail = new System.Windows.Forms.Label();
            this.dtpKasiyerDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblKasiyerDogumTarihi = new System.Windows.Forms.Label();
            this.txtKasiyerAdresi = new System.Windows.Forms.TextBox();
            this.lblKasiyerAdres = new System.Windows.Forms.Label();
            this.txtKasiyerTelefonNo = new System.Windows.Forms.TextBox();
            this.lblKasiyerTelefonNo = new System.Windows.Forms.Label();
            this.txtKasiyerAdSoyad = new System.Windows.Forms.TextBox();
            this.lblKasiyerAdSoyad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageListKasiyerEkle
            // 
            this.ımageListKasiyerEkle.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListKasiyerEkle.ImageStream")));
            this.ımageListKasiyerEkle.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageListKasiyerEkle.Images.SetKeyName(0, "müşteriekle.png");
            // 
            // btnKasiyerEkle
            // 
            this.btnKasiyerEkle.BackColor = System.Drawing.SystemColors.Menu;
            this.btnKasiyerEkle.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKasiyerEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKasiyerEkle.ImageKey = "müşteriekle.png";
            this.btnKasiyerEkle.ImageList = this.ımageListKasiyerEkle;
            this.btnKasiyerEkle.Location = new System.Drawing.Point(542, 425);
            this.btnKasiyerEkle.Name = "btnKasiyerEkle";
            this.btnKasiyerEkle.Size = new System.Drawing.Size(144, 45);
            this.btnKasiyerEkle.TabIndex = 20;
            this.btnKasiyerEkle.Text = "EKLE";
            this.btnKasiyerEkle.UseVisualStyleBackColor = false;
            this.btnKasiyerEkle.Click += new System.EventHandler(this.btnKasiyerEkle_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources._76e022000px_MiGROS_Logo_svg;
            this.pictureBox2.Location = new System.Drawing.Point(248, 74);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(298, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.welc07;
            this.pictureBox1.Location = new System.Drawing.Point(325, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // cbKasaNo
            // 
            this.cbKasaNo.BackColor = System.Drawing.SystemColors.Menu;
            this.cbKasaNo.FormattingEnabled = true;
            this.cbKasaNo.Items.AddRange(new object[] {
            "Kasa 1",
            "Kasa 2 ",
            "Kasa 3",
            "Kasa 4"});
            this.cbKasaNo.Location = new System.Drawing.Point(149, 190);
            this.cbKasaNo.Name = "cbKasaNo";
            this.cbKasaNo.Size = new System.Drawing.Size(181, 21);
            this.cbKasaNo.TabIndex = 2;
            // 
            // lblKasaNo
            // 
            this.lblKasaNo.AutoSize = true;
            this.lblKasaNo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKasaNo.Location = new System.Drawing.Point(51, 189);
            this.lblKasaNo.Name = "lblKasaNo";
            this.lblKasaNo.Size = new System.Drawing.Size(67, 19);
            this.lblKasaNo.TabIndex = 1;
            this.lblKasaNo.Text = "Kasa No:";
            // 
            // txtKasiyerParola
            // 
            this.txtKasiyerParola.BackColor = System.Drawing.SystemColors.Menu;
            this.txtKasiyerParola.Location = new System.Drawing.Point(530, 380);
            this.txtKasiyerParola.Name = "txtKasiyerParola";
            this.txtKasiyerParola.Size = new System.Drawing.Size(181, 20);
            this.txtKasiyerParola.TabIndex = 19;
            // 
            // lblKasiyerParola
            // 
            this.lblKasiyerParola.AutoSize = true;
            this.lblKasiyerParola.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKasiyerParola.Location = new System.Drawing.Point(408, 381);
            this.lblKasiyerParola.Name = "lblKasiyerParola";
            this.lblKasiyerParola.Size = new System.Drawing.Size(53, 19);
            this.lblKasiyerParola.TabIndex = 18;
            this.lblKasiyerParola.Text = "Parola:";
            // 
            // txtKasiyerTcNo
            // 
            this.txtKasiyerTcNo.BackColor = System.Drawing.SystemColors.Menu;
            this.txtKasiyerTcNo.Location = new System.Drawing.Point(149, 241);
            this.txtKasiyerTcNo.Name = "txtKasiyerTcNo";
            this.txtKasiyerTcNo.Size = new System.Drawing.Size(181, 20);
            this.txtKasiyerTcNo.TabIndex = 4;
            // 
            // lblKasiyerTcNo
            // 
            this.lblKasiyerTcNo.AutoSize = true;
            this.lblKasiyerTcNo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKasiyerTcNo.Location = new System.Drawing.Point(51, 239);
            this.lblKasiyerTcNo.Name = "lblKasiyerTcNo";
            this.lblKasiyerTcNo.Size = new System.Drawing.Size(55, 19);
            this.lblKasiyerTcNo.TabIndex = 3;
            this.lblKasiyerTcNo.Text = "Tc No:";
            // 
            // rbKasiyerKadin
            // 
            this.rbKasiyerKadin.AutoSize = true;
            this.rbKasiyerKadin.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbKasiyerKadin.Location = new System.Drawing.Point(625, 186);
            this.rbKasiyerKadin.Name = "rbKasiyerKadin";
            this.rbKasiyerKadin.Size = new System.Drawing.Size(61, 23);
            this.rbKasiyerKadin.TabIndex = 11;
            this.rbKasiyerKadin.TabStop = true;
            this.rbKasiyerKadin.Text = "Kadın";
            this.rbKasiyerKadin.UseVisualStyleBackColor = true;
            // 
            // rbKasiyerErkek
            // 
            this.rbKasiyerErkek.AutoSize = true;
            this.rbKasiyerErkek.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbKasiyerErkek.Location = new System.Drawing.Point(542, 186);
            this.rbKasiyerErkek.Name = "rbKasiyerErkek";
            this.rbKasiyerErkek.Size = new System.Drawing.Size(62, 23);
            this.rbKasiyerErkek.TabIndex = 10;
            this.rbKasiyerErkek.TabStop = true;
            this.rbKasiyerErkek.Text = "Erkek";
            this.rbKasiyerErkek.UseVisualStyleBackColor = true;
            // 
            // lblKasiyerCinsiyet
            // 
            this.lblKasiyerCinsiyet.AutoSize = true;
            this.lblKasiyerCinsiyet.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKasiyerCinsiyet.Location = new System.Drawing.Point(408, 190);
            this.lblKasiyerCinsiyet.Name = "lblKasiyerCinsiyet";
            this.lblKasiyerCinsiyet.Size = new System.Drawing.Size(64, 19);
            this.lblKasiyerCinsiyet.TabIndex = 9;
            this.lblKasiyerCinsiyet.Text = "Cinsiyet:";
            // 
            // txtKasiyerEmailAdresi
            // 
            this.txtKasiyerEmailAdresi.BackColor = System.Drawing.SystemColors.Menu;
            this.txtKasiyerEmailAdresi.Location = new System.Drawing.Point(530, 326);
            this.txtKasiyerEmailAdresi.Name = "txtKasiyerEmailAdresi";
            this.txtKasiyerEmailAdresi.Size = new System.Drawing.Size(181, 20);
            this.txtKasiyerEmailAdresi.TabIndex = 17;
            // 
            // lblKasiyerEmail
            // 
            this.lblKasiyerEmail.AutoSize = true;
            this.lblKasiyerEmail.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKasiyerEmail.Location = new System.Drawing.Point(408, 326);
            this.lblKasiyerEmail.Name = "lblKasiyerEmail";
            this.lblKasiyerEmail.Size = new System.Drawing.Size(100, 19);
            this.lblKasiyerEmail.TabIndex = 16;
            this.lblKasiyerEmail.Text = "E-mail adresi:";
            // 
            // dtpKasiyerDogumTarihi
            // 
            this.dtpKasiyerDogumTarihi.CalendarTitleBackColor = System.Drawing.SystemColors.Menu;
            this.dtpKasiyerDogumTarihi.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpKasiyerDogumTarihi.Location = new System.Drawing.Point(530, 230);
            this.dtpKasiyerDogumTarihi.Name = "dtpKasiyerDogumTarihi";
            this.dtpKasiyerDogumTarihi.Size = new System.Drawing.Size(181, 26);
            this.dtpKasiyerDogumTarihi.TabIndex = 13;
            // 
            // lblKasiyerDogumTarihi
            // 
            this.lblKasiyerDogumTarihi.AutoSize = true;
            this.lblKasiyerDogumTarihi.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKasiyerDogumTarihi.Location = new System.Drawing.Point(408, 230);
            this.lblKasiyerDogumTarihi.Name = "lblKasiyerDogumTarihi";
            this.lblKasiyerDogumTarihi.Size = new System.Drawing.Size(99, 19);
            this.lblKasiyerDogumTarihi.TabIndex = 12;
            this.lblKasiyerDogumTarihi.Text = "Doğum Tarihi:";
            // 
            // txtKasiyerAdresi
            // 
            this.txtKasiyerAdresi.BackColor = System.Drawing.SystemColors.Menu;
            this.txtKasiyerAdresi.Location = new System.Drawing.Point(149, 337);
            this.txtKasiyerAdresi.Multiline = true;
            this.txtKasiyerAdresi.Name = "txtKasiyerAdresi";
            this.txtKasiyerAdresi.Size = new System.Drawing.Size(181, 63);
            this.txtKasiyerAdresi.TabIndex = 8;
            // 
            // lblKasiyerAdres
            // 
            this.lblKasiyerAdres.AutoSize = true;
            this.lblKasiyerAdres.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKasiyerAdres.Location = new System.Drawing.Point(51, 347);
            this.lblKasiyerAdres.Name = "lblKasiyerAdres";
            this.lblKasiyerAdres.Size = new System.Drawing.Size(52, 19);
            this.lblKasiyerAdres.TabIndex = 7;
            this.lblKasiyerAdres.Text = "Adres:";
            // 
            // txtKasiyerTelefonNo
            // 
            this.txtKasiyerTelefonNo.BackColor = System.Drawing.SystemColors.Menu;
            this.txtKasiyerTelefonNo.Location = new System.Drawing.Point(530, 282);
            this.txtKasiyerTelefonNo.Name = "txtKasiyerTelefonNo";
            this.txtKasiyerTelefonNo.Size = new System.Drawing.Size(181, 20);
            this.txtKasiyerTelefonNo.TabIndex = 15;
            // 
            // lblKasiyerTelefonNo
            // 
            this.lblKasiyerTelefonNo.AutoSize = true;
            this.lblKasiyerTelefonNo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKasiyerTelefonNo.Location = new System.Drawing.Point(408, 281);
            this.lblKasiyerTelefonNo.Name = "lblKasiyerTelefonNo";
            this.lblKasiyerTelefonNo.Size = new System.Drawing.Size(87, 19);
            this.lblKasiyerTelefonNo.TabIndex = 14;
            this.lblKasiyerTelefonNo.Text = "Telefon No:";
            // 
            // txtKasiyerAdSoyad
            // 
            this.txtKasiyerAdSoyad.BackColor = System.Drawing.SystemColors.Menu;
            this.txtKasiyerAdSoyad.Location = new System.Drawing.Point(149, 291);
            this.txtKasiyerAdSoyad.Name = "txtKasiyerAdSoyad";
            this.txtKasiyerAdSoyad.Size = new System.Drawing.Size(181, 20);
            this.txtKasiyerAdSoyad.TabIndex = 6;
            // 
            // lblKasiyerAdSoyad
            // 
            this.lblKasiyerAdSoyad.AutoSize = true;
            this.lblKasiyerAdSoyad.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKasiyerAdSoyad.Location = new System.Drawing.Point(51, 291);
            this.lblKasiyerAdSoyad.Name = "lblKasiyerAdSoyad";
            this.lblKasiyerAdSoyad.Size = new System.Drawing.Size(77, 19);
            this.lblKasiyerAdSoyad.TabIndex = 5;
            this.lblKasiyerAdSoyad.Text = "Ad Soyad:";
            // 
            // KasiyerEklemeEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.cbKasaNo);
            this.Controls.Add(this.lblKasaNo);
            this.Controls.Add(this.txtKasiyerParola);
            this.Controls.Add(this.lblKasiyerParola);
            this.Controls.Add(this.txtKasiyerTcNo);
            this.Controls.Add(this.lblKasiyerTcNo);
            this.Controls.Add(this.rbKasiyerKadin);
            this.Controls.Add(this.rbKasiyerErkek);
            this.Controls.Add(this.lblKasiyerCinsiyet);
            this.Controls.Add(this.txtKasiyerEmailAdresi);
            this.Controls.Add(this.lblKasiyerEmail);
            this.Controls.Add(this.dtpKasiyerDogumTarihi);
            this.Controls.Add(this.lblKasiyerDogumTarihi);
            this.Controls.Add(this.txtKasiyerAdresi);
            this.Controls.Add(this.lblKasiyerAdres);
            this.Controls.Add(this.txtKasiyerTelefonNo);
            this.Controls.Add(this.lblKasiyerTelefonNo);
            this.Controls.Add(this.txtKasiyerAdSoyad);
            this.Controls.Add(this.lblKasiyerAdSoyad);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnKasiyerEkle);
            this.Name = "KasiyerEklemeEkranı";
            this.Text = "KasiyerEklemeEkranı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKasiyerEkle;
        private System.Windows.Forms.ImageList ımageListKasiyerEkle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbKasaNo;
        private System.Windows.Forms.Label lblKasaNo;
        private System.Windows.Forms.TextBox txtKasiyerParola;
        private System.Windows.Forms.Label lblKasiyerParola;
        private System.Windows.Forms.TextBox txtKasiyerTcNo;
        private System.Windows.Forms.Label lblKasiyerTcNo;
        private System.Windows.Forms.RadioButton rbKasiyerKadin;
        private System.Windows.Forms.RadioButton rbKasiyerErkek;
        private System.Windows.Forms.Label lblKasiyerCinsiyet;
        private System.Windows.Forms.TextBox txtKasiyerEmailAdresi;
        private System.Windows.Forms.Label lblKasiyerEmail;
        private System.Windows.Forms.DateTimePicker dtpKasiyerDogumTarihi;
        private System.Windows.Forms.Label lblKasiyerDogumTarihi;
        private System.Windows.Forms.TextBox txtKasiyerAdresi;
        private System.Windows.Forms.Label lblKasiyerAdres;
        private System.Windows.Forms.TextBox txtKasiyerTelefonNo;
        private System.Windows.Forms.Label lblKasiyerTelefonNo;
        private System.Windows.Forms.TextBox txtKasiyerAdSoyad;
        private System.Windows.Forms.Label lblKasiyerAdSoyad;

    }
}