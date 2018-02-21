namespace WindowsFormsApplication1
{
    partial class SatisEklemeEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SatisEklemeEkrani));
            this.lblUrunKodu = new System.Windows.Forms.Label();
            this.txtSatisUrunKodu = new System.Windows.Forms.TextBox();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.lblUrunMiktari = new System.Windows.Forms.Label();
            this.lblSatisUrunAdi = new System.Windows.Forms.Label();
            this.txtUrunSatisMiktari = new System.Windows.Forms.TextBox();
            this.lblUrunFiyati = new System.Windows.Forms.Label();
            this.lblUrunSatisFiyati = new System.Windows.Forms.Label();
            this.lblSatisTutar = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.ımageListSatisEkle = new System.Windows.Forms.ImageList(this.components);
            this.txtKartNo = new System.Windows.Forms.TextBox();
            this.lblKartNo = new System.Windows.Forms.Label();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.lblParaUstuHesabi = new System.Windows.Forms.Label();
            this.txtVerilenPara = new System.Windows.Forms.TextBox();
            this.txtParaUstu = new System.Windows.Forms.TextBox();
            this.panelSepeteEkle = new System.Windows.Forms.Panel();
            this.btnListele = new System.Windows.Forms.Button();
            this.lblSatisTarihi = new System.Windows.Forms.Label();
            this.btnTutarHesapla = new System.Windows.Forms.Button();
            this.dateTimePickerSatisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSatisYap = new System.Windows.Forms.Button();
            this.rbNakit = new System.Windows.Forms.RadioButton();
            this.lblOdemeTipi = new System.Windows.Forms.Label();
            this.rbKrediKarti = new System.Windows.Forms.RadioButton();
            this.dgSatisKalemi = new System.Windows.Forms.DataGridView();
            this.rbPuanKullanmaDurumu = new System.Windows.Forms.RadioButton();
            this.panelSepeteEkle.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSatisKalemi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUrunKodu
            // 
            this.lblUrunKodu.AutoSize = true;
            this.lblUrunKodu.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunKodu.Location = new System.Drawing.Point(20, 93);
            this.lblUrunKodu.Name = "lblUrunKodu";
            this.lblUrunKodu.Size = new System.Drawing.Size(76, 18);
            this.lblUrunKodu.TabIndex = 5;
            this.lblUrunKodu.Text = "Ürün Kodu:";
            // 
            // txtSatisUrunKodu
            // 
            this.txtSatisUrunKodu.Location = new System.Drawing.Point(157, 91);
            this.txtSatisUrunKodu.Name = "txtSatisUrunKodu";
            this.txtSatisUrunKodu.Size = new System.Drawing.Size(100, 20);
            this.txtSatisUrunKodu.TabIndex = 6;
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAdi.Location = new System.Drawing.Point(20, 222);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(67, 18);
            this.lblUrunAdi.TabIndex = 10;
            this.lblUrunAdi.Text = "Ürün Adı:";
            // 
            // lblUrunMiktari
            // 
            this.lblUrunMiktari.AutoSize = true;
            this.lblUrunMiktari.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunMiktari.Location = new System.Drawing.Point(20, 133);
            this.lblUrunMiktari.Name = "lblUrunMiktari";
            this.lblUrunMiktari.Size = new System.Drawing.Size(90, 18);
            this.lblUrunMiktari.TabIndex = 7;
            this.lblUrunMiktari.Text = "Ürün Miktarı:";
            // 
            // lblSatisUrunAdi
            // 
            this.lblSatisUrunAdi.AutoSize = true;
            this.lblSatisUrunAdi.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatisUrunAdi.ForeColor = System.Drawing.Color.Red;
            this.lblSatisUrunAdi.Location = new System.Drawing.Point(112, 222);
            this.lblSatisUrunAdi.Name = "lblSatisUrunAdi";
            this.lblSatisUrunAdi.Size = new System.Drawing.Size(0, 18);
            this.lblSatisUrunAdi.TabIndex = 6;
            // 
            // txtUrunSatisMiktari
            // 
            this.txtUrunSatisMiktari.Location = new System.Drawing.Point(157, 134);
            this.txtUrunSatisMiktari.Name = "txtUrunSatisMiktari";
            this.txtUrunSatisMiktari.Size = new System.Drawing.Size(100, 20);
            this.txtUrunSatisMiktari.TabIndex = 8;
            // 
            // lblUrunFiyati
            // 
            this.lblUrunFiyati.AutoSize = true;
            this.lblUrunFiyati.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunFiyati.Location = new System.Drawing.Point(20, 253);
            this.lblUrunFiyati.Name = "lblUrunFiyati";
            this.lblUrunFiyati.Size = new System.Drawing.Size(81, 18);
            this.lblUrunFiyati.TabIndex = 8;
            this.lblUrunFiyati.Text = "Ürün Fiyatı:";
            // 
            // lblUrunSatisFiyati
            // 
            this.lblUrunSatisFiyati.AutoSize = true;
            this.lblUrunSatisFiyati.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunSatisFiyati.ForeColor = System.Drawing.Color.Red;
            this.lblUrunSatisFiyati.Location = new System.Drawing.Point(112, 253);
            this.lblUrunSatisFiyati.Name = "lblUrunSatisFiyati";
            this.lblUrunSatisFiyati.Size = new System.Drawing.Size(0, 18);
            this.lblUrunSatisFiyati.TabIndex = 9;
            // 
            // lblSatisTutar
            // 
            this.lblSatisTutar.AutoSize = true;
            this.lblSatisTutar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatisTutar.ForeColor = System.Drawing.Color.Red;
            this.lblSatisTutar.Location = new System.Drawing.Point(112, 280);
            this.lblSatisTutar.Name = "lblSatisTutar";
            this.lblSatisTutar.Size = new System.Drawing.Size(0, 18);
            this.lblSatisTutar.TabIndex = 11;
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.Location = new System.Drawing.Point(20, 280);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(46, 18);
            this.lblTutar.TabIndex = 10;
            this.lblTutar.Text = "Tutar:";
            // 
            // ımageListSatisEkle
            // 
            this.ımageListSatisEkle.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListSatisEkle.ImageStream")));
            this.ımageListSatisEkle.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageListSatisEkle.Images.SetKeyName(0, "Shopping-basket-add-icon.png");
            this.ımageListSatisEkle.Images.SetKeyName(1, "promo-icon-16.png");
            this.ımageListSatisEkle.Images.SetKeyName(2, "money-icon.png");
            // 
            // txtKartNo
            // 
            this.txtKartNo.Location = new System.Drawing.Point(159, 52);
            this.txtKartNo.Name = "txtKartNo";
            this.txtKartNo.Size = new System.Drawing.Size(100, 20);
            this.txtKartNo.TabIndex = 4;
            // 
            // lblKartNo
            // 
            this.lblKartNo.AutoSize = true;
            this.lblKartNo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKartNo.Location = new System.Drawing.Point(20, 54);
            this.lblKartNo.Name = "lblKartNo";
            this.lblKartNo.Size = new System.Drawing.Size(133, 18);
            this.lblKartNo.TabIndex = 3;
            this.lblKartNo.Text = "Money Club Kart No:";
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplamTutar.ForeColor = System.Drawing.Color.Red;
            this.txtToplamTutar.Location = new System.Drawing.Point(31, 51);
            this.txtToplamTutar.Multiline = true;
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.Size = new System.Drawing.Size(236, 35);
            this.txtToplamTutar.TabIndex = 15;
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.Location = new System.Drawing.Point(28, 28);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(97, 18);
            this.lblToplamTutar.TabIndex = 16;
            this.lblToplamTutar.Text = "Toplam Tutar :";
            // 
            // lblParaUstuHesabi
            // 
            this.lblParaUstuHesabi.AutoSize = true;
            this.lblParaUstuHesabi.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParaUstuHesabi.Location = new System.Drawing.Point(28, 160);
            this.lblParaUstuHesabi.Name = "lblParaUstuHesabi";
            this.lblParaUstuHesabi.Size = new System.Drawing.Size(117, 18);
            this.lblParaUstuHesabi.TabIndex = 18;
            this.lblParaUstuHesabi.Text = "Para Üstü Hesabı:";
            // 
            // txtVerilenPara
            // 
            this.txtVerilenPara.Location = new System.Drawing.Point(31, 186);
            this.txtVerilenPara.Multiline = true;
            this.txtVerilenPara.Name = "txtVerilenPara";
            this.txtVerilenPara.Size = new System.Drawing.Size(103, 20);
            this.txtVerilenPara.TabIndex = 13;
            this.txtVerilenPara.Text = "Alınan Miktar";
            // 
            // txtParaUstu
            // 
            this.txtParaUstu.Location = new System.Drawing.Point(173, 186);
            this.txtParaUstu.Multiline = true;
            this.txtParaUstu.Name = "txtParaUstu";
            this.txtParaUstu.Size = new System.Drawing.Size(94, 20);
            this.txtParaUstu.TabIndex = 19;
            this.txtParaUstu.Text = "Para Üstü";
            // 
            // panelSepeteEkle
            // 
            this.panelSepeteEkle.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panelSepeteEkle.Controls.Add(this.rbPuanKullanmaDurumu);
            this.panelSepeteEkle.Controls.Add(this.btnListele);
            this.panelSepeteEkle.Controls.Add(this.lblSatisTarihi);
            this.panelSepeteEkle.Controls.Add(this.btnTutarHesapla);
            this.panelSepeteEkle.Controls.Add(this.dateTimePickerSatisTarihi);
            this.panelSepeteEkle.Controls.Add(this.label1);
            this.panelSepeteEkle.Controls.Add(this.txtSatisUrunKodu);
            this.panelSepeteEkle.Controls.Add(this.txtUrunSatisMiktari);
            this.panelSepeteEkle.Controls.Add(this.txtKartNo);
            this.panelSepeteEkle.Controls.Add(this.lblKartNo);
            this.panelSepeteEkle.Controls.Add(this.lblUrunKodu);
            this.panelSepeteEkle.Controls.Add(this.lblUrunAdi);
            this.panelSepeteEkle.Controls.Add(this.lblUrunMiktari);
            this.panelSepeteEkle.Controls.Add(this.lblSatisUrunAdi);
            this.panelSepeteEkle.Controls.Add(this.lblUrunFiyati);
            this.panelSepeteEkle.Controls.Add(this.lblUrunSatisFiyati);
            this.panelSepeteEkle.Controls.Add(this.lblTutar);
            this.panelSepeteEkle.Controls.Add(this.lblSatisTutar);
            this.panelSepeteEkle.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelSepeteEkle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelSepeteEkle.Location = new System.Drawing.Point(12, 12);
            this.panelSepeteEkle.Name = "panelSepeteEkle";
            this.panelSepeteEkle.Size = new System.Drawing.Size(372, 338);
            this.panelSepeteEkle.TabIndex = 20;
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListele.ImageKey = "money-icon.png";
            this.btnListele.Location = new System.Drawing.Point(157, 172);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(100, 34);
            this.btnListele.TabIndex = 9;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // lblSatisTarihi
            // 
            this.lblSatisTarihi.AutoSize = true;
            this.lblSatisTarihi.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatisTarihi.Location = new System.Drawing.Point(20, 18);
            this.lblSatisTarihi.Name = "lblSatisTarihi";
            this.lblSatisTarihi.Size = new System.Drawing.Size(80, 18);
            this.lblSatisTarihi.TabIndex = 1;
            this.lblSatisTarihi.Text = "Satış Tarihi";
            // 
            // btnTutarHesapla
            // 
            this.btnTutarHesapla.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTutarHesapla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTutarHesapla.ImageKey = "money-icon.png";
            this.btnTutarHesapla.ImageList = this.ımageListSatisEkle;
            this.btnTutarHesapla.Location = new System.Drawing.Point(220, 280);
            this.btnTutarHesapla.Name = "btnTutarHesapla";
            this.btnTutarHesapla.Size = new System.Drawing.Size(137, 46);
            this.btnTutarHesapla.TabIndex = 10;
            this.btnTutarHesapla.Text = "Tutar Hesapla";
            this.btnTutarHesapla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTutarHesapla.UseVisualStyleBackColor = true;
            this.btnTutarHesapla.Click += new System.EventHandler(this.btnTutarHesapla_Click);
            // 
            // dateTimePickerSatisTarihi
            // 
            this.dateTimePickerSatisTarihi.Location = new System.Drawing.Point(157, 16);
            this.dateTimePickerSatisTarihi.Name = "dateTimePickerSatisTarihi";
            this.dateTimePickerSatisTarihi.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerSatisTarihi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(90, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.btnSatisYap);
            this.panel1.Controls.Add(this.rbNakit);
            this.panel1.Controls.Add(this.lblOdemeTipi);
            this.panel1.Controls.Add(this.rbKrediKarti);
            this.panel1.Controls.Add(this.txtParaUstu);
            this.panel1.Controls.Add(this.txtToplamTutar);
            this.panel1.Controls.Add(this.lblParaUstuHesabi);
            this.panel1.Controls.Add(this.lblToplamTutar);
            this.panel1.Controls.Add(this.txtVerilenPara);
            this.panel1.Location = new System.Drawing.Point(407, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 338);
            this.panel1.TabIndex = 21;
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisYap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSatisYap.ImageKey = "promo-icon-16.png";
            this.btnSatisYap.ImageList = this.ımageListSatisEkle;
            this.btnSatisYap.Location = new System.Drawing.Point(31, 245);
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(120, 46);
            this.btnSatisYap.TabIndex = 14;
            this.btnSatisYap.Text = "Satış Yap";
            this.btnSatisYap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSatisYap.UseVisualStyleBackColor = true;
            this.btnSatisYap.Click += new System.EventHandler(this.btnSatisYap_Click);
            // 
            // rbNakit
            // 
            this.rbNakit.AutoSize = true;
            this.rbNakit.Checked = true;
            this.rbNakit.Location = new System.Drawing.Point(133, 120);
            this.rbNakit.Name = "rbNakit";
            this.rbNakit.Size = new System.Drawing.Size(50, 17);
            this.rbNakit.TabIndex = 11;
            this.rbNakit.TabStop = true;
            this.rbNakit.Text = "Nakit";
            this.rbNakit.UseVisualStyleBackColor = true;
            // 
            // lblOdemeTipi
            // 
            this.lblOdemeTipi.AutoSize = true;
            this.lblOdemeTipi.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdemeTipi.Location = new System.Drawing.Point(28, 119);
            this.lblOdemeTipi.Name = "lblOdemeTipi";
            this.lblOdemeTipi.Size = new System.Drawing.Size(81, 18);
            this.lblOdemeTipi.TabIndex = 24;
            this.lblOdemeTipi.Text = "Ödeme Tipi:";
            // 
            // rbKrediKarti
            // 
            this.rbKrediKarti.AutoSize = true;
            this.rbKrediKarti.Location = new System.Drawing.Point(194, 120);
            this.rbKrediKarti.Name = "rbKrediKarti";
            this.rbKrediKarti.Size = new System.Drawing.Size(73, 17);
            this.rbKrediKarti.TabIndex = 12;
            this.rbKrediKarti.Text = "Kredi Kartı";
            this.rbKrediKarti.UseVisualStyleBackColor = true;
            // 
            // dgSatisKalemi
            // 
            this.dgSatisKalemi.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgSatisKalemi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSatisKalemi.Location = new System.Drawing.Point(127, 377);
            this.dgSatisKalemi.Name = "dgSatisKalemi";
            this.dgSatisKalemi.Size = new System.Drawing.Size(534, 139);
            this.dgSatisKalemi.TabIndex = 22;
            // 
            // rbPuanKullanmaDurumu
            // 
            this.rbPuanKullanmaDurumu.AutoSize = true;
            this.rbPuanKullanmaDurumu.Location = new System.Drawing.Point(220, 253);
            this.rbPuanKullanmaDurumu.Name = "rbPuanKullanmaDurumu";
            this.rbPuanKullanmaDurumu.Size = new System.Drawing.Size(80, 17);
            this.rbPuanKullanmaDurumu.TabIndex = 26;
            this.rbPuanKullanmaDurumu.Text = "Puan Kulan";
            this.rbPuanKullanmaDurumu.UseVisualStyleBackColor = true;
            // 
            // SatisEklemeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dgSatisKalemi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSepeteEkle);
            this.Name = "SatisEklemeEkrani";
            this.Text = "SatisEklemeEkrani";
            this.panelSepeteEkle.ResumeLayout(false);
            this.panelSepeteEkle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSatisKalemi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUrunKodu;
        private System.Windows.Forms.TextBox txtSatisUrunKodu;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.Label lblUrunMiktari;
        private System.Windows.Forms.Label lblSatisUrunAdi;
        private System.Windows.Forms.TextBox txtUrunSatisMiktari;
        private System.Windows.Forms.Label lblUrunFiyati;
        private System.Windows.Forms.Label lblUrunSatisFiyati;
        private System.Windows.Forms.Label lblSatisTutar;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.TextBox txtKartNo;
        private System.Windows.Forms.Label lblKartNo;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label lblParaUstuHesabi;
        private System.Windows.Forms.TextBox txtVerilenPara;
        private System.Windows.Forms.TextBox txtParaUstu;
        private System.Windows.Forms.Panel panelSepeteEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbNakit;
        private System.Windows.Forms.Label lblOdemeTipi;
        private System.Windows.Forms.RadioButton rbKrediKarti;
        private System.Windows.Forms.ImageList ımageListSatisEkle;
        private System.Windows.Forms.Button btnSatisYap;
        private System.Windows.Forms.Button btnTutarHesapla;
        private System.Windows.Forms.Label lblSatisTarihi;
        private System.Windows.Forms.DateTimePicker dateTimePickerSatisTarihi;
        private System.Windows.Forms.DataGridView dgSatisKalemi;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.RadioButton rbPuanKullanmaDurumu;
    }
}