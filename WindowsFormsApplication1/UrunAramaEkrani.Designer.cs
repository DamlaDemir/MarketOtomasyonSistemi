namespace WindowsFormsApplication1
{
    partial class UrunAramaEkrani
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUrunAra = new System.Windows.Forms.Button();
            this.txtUrunKodu = new System.Windows.Forms.TextBox();
            this.lblUrunKodu = new System.Windows.Forms.Label();
            this.txtBulunanUrun = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources._76e022000px_MiGROS_Logo_svg;
            this.pictureBox2.Location = new System.Drawing.Point(228, 93);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(298, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.welc07;
            this.pictureBox1.Location = new System.Drawing.Point(305, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // btnUrunAra
            // 
            this.btnUrunAra.BackColor = System.Drawing.SystemColors.Menu;
            this.btnUrunAra.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunAra.ImageKey = "search_male_user.png";
            this.btnUrunAra.Location = new System.Drawing.Point(415, 162);
            this.btnUrunAra.Name = "btnUrunAra";
            this.btnUrunAra.Size = new System.Drawing.Size(145, 39);
            this.btnUrunAra.TabIndex = 27;
            this.btnUrunAra.Text = "ARA";
            this.btnUrunAra.UseVisualStyleBackColor = false;
            this.btnUrunAra.Click += new System.EventHandler(this.btnUrunAra_Click);
            // 
            // txtUrunKodu
            // 
            this.txtUrunKodu.Location = new System.Drawing.Point(249, 174);
            this.txtUrunKodu.Multiline = true;
            this.txtUrunKodu.Name = "txtUrunKodu";
            this.txtUrunKodu.Size = new System.Drawing.Size(144, 23);
            this.txtUrunKodu.TabIndex = 26;
            // 
            // lblUrunKodu
            // 
            this.lblUrunKodu.AutoSize = true;
            this.lblUrunKodu.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunKodu.Location = new System.Drawing.Point(172, 174);
            this.lblUrunKodu.Name = "lblUrunKodu";
            this.lblUrunKodu.Size = new System.Drawing.Size(81, 19);
            this.lblUrunKodu.TabIndex = 25;
            this.lblUrunKodu.Text = "Ürün Kodu:";
            // 
            // txtBulunanUrun
            // 
            this.txtBulunanUrun.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBulunanUrun.Location = new System.Drawing.Point(85, 240);
            this.txtBulunanUrun.Multiline = true;
            this.txtBulunanUrun.Name = "txtBulunanUrun";
            this.txtBulunanUrun.Size = new System.Drawing.Size(608, 81);
            this.txtBulunanUrun.TabIndex = 31;
            // 
            // UrunAramaEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.txtBulunanUrun);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnUrunAra);
            this.Controls.Add(this.txtUrunKodu);
            this.Controls.Add(this.lblUrunKodu);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "UrunAramaEkrani";
            this.Text = "UrunAramaEkrani";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUrunAra;
        private System.Windows.Forms.TextBox txtUrunKodu;
        private System.Windows.Forms.Label lblUrunKodu;
        private System.Windows.Forms.TextBox txtBulunanUrun;
    }
}