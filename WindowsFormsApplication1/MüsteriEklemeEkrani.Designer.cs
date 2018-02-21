namespace WindowsFormsApplication1
{
    partial class MüsteriEklemeEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MüsteriEklemeEkrani));
            this.imlistMusteriEkle = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.txtKartNo = new System.Windows.Forms.TextBox();
            this.lblKartNo = new System.Windows.Forms.Label();
            this.rbMusteriKadin = new System.Windows.Forms.RadioButton();
            this.rbMusteriErkek = new System.Windows.Forms.RadioButton();
            this.lblMusteriCinsiyet = new System.Windows.Forms.Label();
            this.txtEmailAdresi = new System.Windows.Forms.TextBox();
            this.lblMusteriEmail = new System.Windows.Forms.Label();
            this.dtpMusteriDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblMusteriDogumTarihi = new System.Windows.Forms.Label();
            this.txtMusteriAdresi = new System.Windows.Forms.TextBox();
            this.lblMusteriAdres = new System.Windows.Forms.Label();
            this.txtMusteriTelefonNo = new System.Windows.Forms.TextBox();
            this.lblMusteriTelefonNo = new System.Windows.Forms.Label();
            this.txtMusteriAdSoyad = new System.Windows.Forms.TextBox();
            this.lblMusteriAdSoyad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imlistMusteriEkle
            // 
            this.imlistMusteriEkle.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlistMusteriEkle.ImageStream")));
            this.imlistMusteriEkle.TransparentColor = System.Drawing.Color.Transparent;
            this.imlistMusteriEkle.Images.SetKeyName(0, "müşteriekle.png");
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources._76e022000px_MiGROS_Logo_svg;
            this.pictureBox2.Location = new System.Drawing.Point(224, 83);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(298, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.welc07;
            this.pictureBox1.Location = new System.Drawing.Point(301, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.BackColor = System.Drawing.SystemColors.Menu;
            this.btnMusteriEkle.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteriEkle.ImageKey = "müşteriekle.png";
            this.btnMusteriEkle.ImageList = this.imlistMusteriEkle;
            this.btnMusteriEkle.Location = new System.Drawing.Point(505, 327);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(144, 45);
            this.btnMusteriEkle.TabIndex = 17;
            this.btnMusteriEkle.Text = "EKLE";
            this.btnMusteriEkle.UseVisualStyleBackColor = false;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // txtKartNo
            // 
            this.txtKartNo.BackColor = System.Drawing.SystemColors.Menu;
            this.txtKartNo.Location = new System.Drawing.Point(151, 157);
            this.txtKartNo.Name = "txtKartNo";
            this.txtKartNo.Size = new System.Drawing.Size(181, 20);
            this.txtKartNo.TabIndex = 2;
            // 
            // lblKartNo
            // 
            this.lblKartNo.AutoSize = true;
            this.lblKartNo.BackColor = System.Drawing.SystemColors.Window;
            this.lblKartNo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKartNo.Location = new System.Drawing.Point(30, 158);
            this.lblKartNo.Name = "lblKartNo";
            this.lblKartNo.Size = new System.Drawing.Size(66, 19);
            this.lblKartNo.TabIndex = 1;
            this.lblKartNo.Text = "Kart No:";
            // 
            // rbMusteriKadin
            // 
            this.rbMusteriKadin.AutoSize = true;
            this.rbMusteriKadin.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbMusteriKadin.Location = new System.Drawing.Point(223, 283);
            this.rbMusteriKadin.Name = "rbMusteriKadin";
            this.rbMusteriKadin.Size = new System.Drawing.Size(61, 23);
            this.rbMusteriKadin.TabIndex = 10;
            this.rbMusteriKadin.TabStop = true;
            this.rbMusteriKadin.Text = "Kadın";
            this.rbMusteriKadin.UseVisualStyleBackColor = true;
            // 
            // rbMusteriErkek
            // 
            this.rbMusteriErkek.AutoSize = true;
            this.rbMusteriErkek.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbMusteriErkek.Location = new System.Drawing.Point(155, 283);
            this.rbMusteriErkek.Name = "rbMusteriErkek";
            this.rbMusteriErkek.Size = new System.Drawing.Size(62, 23);
            this.rbMusteriErkek.TabIndex = 9;
            this.rbMusteriErkek.TabStop = true;
            this.rbMusteriErkek.Text = "Erkek";
            this.rbMusteriErkek.UseVisualStyleBackColor = true;
            // 
            // lblMusteriCinsiyet
            // 
            this.lblMusteriCinsiyet.AutoSize = true;
            this.lblMusteriCinsiyet.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriCinsiyet.Location = new System.Drawing.Point(30, 283);
            this.lblMusteriCinsiyet.Name = "lblMusteriCinsiyet";
            this.lblMusteriCinsiyet.Size = new System.Drawing.Size(64, 19);
            this.lblMusteriCinsiyet.TabIndex = 7;
            this.lblMusteriCinsiyet.Text = "Cinsiyet:";
            // 
            // txtEmailAdresi
            // 
            this.txtEmailAdresi.BackColor = System.Drawing.SystemColors.Menu;
            this.txtEmailAdresi.Location = new System.Drawing.Point(491, 282);
            this.txtEmailAdresi.Name = "txtEmailAdresi";
            this.txtEmailAdresi.Size = new System.Drawing.Size(181, 20);
            this.txtEmailAdresi.TabIndex = 16;
            // 
            // lblMusteriEmail
            // 
            this.lblMusteriEmail.AutoSize = true;
            this.lblMusteriEmail.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriEmail.Location = new System.Drawing.Point(385, 284);
            this.lblMusteriEmail.Name = "lblMusteriEmail";
            this.lblMusteriEmail.Size = new System.Drawing.Size(100, 19);
            this.lblMusteriEmail.TabIndex = 15;
            this.lblMusteriEmail.Text = "E-mail adresi:";
            // 
            // dtpMusteriDogumTarihi
            // 
            this.dtpMusteriDogumTarihi.CalendarTitleBackColor = System.Drawing.SystemColors.Menu;
            this.dtpMusteriDogumTarihi.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpMusteriDogumTarihi.Location = new System.Drawing.Point(151, 239);
            this.dtpMusteriDogumTarihi.Name = "dtpMusteriDogumTarihi";
            this.dtpMusteriDogumTarihi.Size = new System.Drawing.Size(181, 26);
            this.dtpMusteriDogumTarihi.TabIndex = 6;
            // 
            // lblMusteriDogumTarihi
            // 
            this.lblMusteriDogumTarihi.AutoSize = true;
            this.lblMusteriDogumTarihi.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriDogumTarihi.Location = new System.Drawing.Point(30, 244);
            this.lblMusteriDogumTarihi.Name = "lblMusteriDogumTarihi";
            this.lblMusteriDogumTarihi.Size = new System.Drawing.Size(99, 19);
            this.lblMusteriDogumTarihi.TabIndex = 5;
            this.lblMusteriDogumTarihi.Text = "Doğum Tarihi:";
            // 
            // txtMusteriAdresi
            // 
            this.txtMusteriAdresi.BackColor = System.Drawing.SystemColors.Menu;
            this.txtMusteriAdresi.Location = new System.Drawing.Point(491, 159);
            this.txtMusteriAdresi.Multiline = true;
            this.txtMusteriAdresi.Name = "txtMusteriAdresi";
            this.txtMusteriAdresi.Size = new System.Drawing.Size(181, 63);
            this.txtMusteriAdresi.TabIndex = 12;
            // 
            // lblMusteriAdres
            // 
            this.lblMusteriAdres.AutoSize = true;
            this.lblMusteriAdres.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriAdres.Location = new System.Drawing.Point(385, 179);
            this.lblMusteriAdres.Name = "lblMusteriAdres";
            this.lblMusteriAdres.Size = new System.Drawing.Size(52, 19);
            this.lblMusteriAdres.TabIndex = 11;
            this.lblMusteriAdres.Text = "Adres:";
            // 
            // txtMusteriTelefonNo
            // 
            this.txtMusteriTelefonNo.BackColor = System.Drawing.SystemColors.Menu;
            this.txtMusteriTelefonNo.Location = new System.Drawing.Point(491, 239);
            this.txtMusteriTelefonNo.Name = "txtMusteriTelefonNo";
            this.txtMusteriTelefonNo.Size = new System.Drawing.Size(181, 20);
            this.txtMusteriTelefonNo.TabIndex = 14;
            // 
            // lblMusteriTelefonNo
            // 
            this.lblMusteriTelefonNo.AutoSize = true;
            this.lblMusteriTelefonNo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriTelefonNo.Location = new System.Drawing.Point(385, 239);
            this.lblMusteriTelefonNo.Name = "lblMusteriTelefonNo";
            this.lblMusteriTelefonNo.Size = new System.Drawing.Size(87, 19);
            this.lblMusteriTelefonNo.TabIndex = 13;
            this.lblMusteriTelefonNo.Text = "Telefon No:";
            // 
            // txtMusteriAdSoyad
            // 
            this.txtMusteriAdSoyad.BackColor = System.Drawing.SystemColors.Menu;
            this.txtMusteriAdSoyad.Location = new System.Drawing.Point(151, 204);
            this.txtMusteriAdSoyad.Name = "txtMusteriAdSoyad";
            this.txtMusteriAdSoyad.Size = new System.Drawing.Size(181, 20);
            this.txtMusteriAdSoyad.TabIndex = 4;
            // 
            // lblMusteriAdSoyad
            // 
            this.lblMusteriAdSoyad.AutoSize = true;
            this.lblMusteriAdSoyad.BackColor = System.Drawing.SystemColors.Window;
            this.lblMusteriAdSoyad.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriAdSoyad.Location = new System.Drawing.Point(30, 205);
            this.lblMusteriAdSoyad.Name = "lblMusteriAdSoyad";
            this.lblMusteriAdSoyad.Size = new System.Drawing.Size(77, 19);
            this.lblMusteriAdSoyad.TabIndex = 3;
            this.lblMusteriAdSoyad.Text = "Ad Soyad:";
            // 
            // MüsteriEklemeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(721, 418);
            this.Controls.Add(this.txtKartNo);
            this.Controls.Add(this.lblKartNo);
            this.Controls.Add(this.rbMusteriKadin);
            this.Controls.Add(this.rbMusteriErkek);
            this.Controls.Add(this.lblMusteriCinsiyet);
            this.Controls.Add(this.txtEmailAdresi);
            this.Controls.Add(this.lblMusteriEmail);
            this.Controls.Add(this.dtpMusteriDogumTarihi);
            this.Controls.Add(this.lblMusteriDogumTarihi);
            this.Controls.Add(this.txtMusteriAdresi);
            this.Controls.Add(this.lblMusteriAdres);
            this.Controls.Add(this.txtMusteriTelefonNo);
            this.Controls.Add(this.lblMusteriTelefonNo);
            this.Controls.Add(this.txtMusteriAdSoyad);
            this.Controls.Add(this.lblMusteriAdSoyad);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMusteriEkle);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MüsteriEklemeEkrani";
            this.Text = "MüsteriEklemeEkrani";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.ImageList imlistMusteriEkle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtKartNo;
        private System.Windows.Forms.Label lblKartNo;
        private System.Windows.Forms.RadioButton rbMusteriKadin;
        private System.Windows.Forms.RadioButton rbMusteriErkek;
        private System.Windows.Forms.Label lblMusteriCinsiyet;
        private System.Windows.Forms.TextBox txtEmailAdresi;
        private System.Windows.Forms.Label lblMusteriEmail;
        private System.Windows.Forms.DateTimePicker dtpMusteriDogumTarihi;
        private System.Windows.Forms.Label lblMusteriDogumTarihi;
        private System.Windows.Forms.TextBox txtMusteriAdresi;
        private System.Windows.Forms.Label lblMusteriAdres;
        private System.Windows.Forms.TextBox txtMusteriTelefonNo;
        private System.Windows.Forms.Label lblMusteriTelefonNo;
        private System.Windows.Forms.TextBox txtMusteriAdSoyad;
        private System.Windows.Forms.Label lblMusteriAdSoyad;
    }
}