namespace InstagramTestProject
{
    partial class Instagram
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPaylas = new System.Windows.Forms.Button();
            this.lblGonderiIsim = new System.Windows.Forms.Label();
            this.btnResimSec = new System.Windows.Forms.Button();
            this.lblResimSec = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGirisYap);
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Controls.Add(this.lblSifre);
            this.groupBox1.Controls.Add(this.txtKullaniciAdi);
            this.groupBox1.Controls.Add(this.lblKullaniciAdi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 134);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş";
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(146, 81);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(75, 32);
            this.btnGirisYap.TabIndex = 4;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(104, 53);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(117, 22);
            this.txtSifre.TabIndex = 3;
            this.txtSifre.Text = "Eyisörahcegi";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(6, 56);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(45, 17);
            this.lblSifre.TabIndex = 2;
            this.lblSifre.Text = "Şifre: ";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(104, 25);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(117, 22);
            this.txtKullaniciAdi.TabIndex = 1;
            this.txtKullaniciAdi.Text = "beykentymk";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(6, 28);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(92, 17);
            this.lblKullaniciAdi.TabIndex = 0;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPaylas);
            this.groupBox2.Controls.Add(this.lblGonderiIsim);
            this.groupBox2.Controls.Add(this.btnResimSec);
            this.groupBox2.Controls.Add(this.lblResimSec);
            this.groupBox2.Location = new System.Drawing.Point(12, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gönderi Paylaş";
            // 
            // btnPaylas
            // 
            this.btnPaylas.Location = new System.Drawing.Point(92, 50);
            this.btnPaylas.Name = "btnPaylas";
            this.btnPaylas.Size = new System.Drawing.Size(129, 27);
            this.btnPaylas.TabIndex = 3;
            this.btnPaylas.Text = "Gönderi Paylaş";
            this.btnPaylas.UseVisualStyleBackColor = true;
            this.btnPaylas.Click += new System.EventHandler(this.BtnPaylas_Click);
            // 
            // lblGonderiIsim
            // 
            this.lblGonderiIsim.AutoSize = true;
            this.lblGonderiIsim.Location = new System.Drawing.Point(6, 80);
            this.lblGonderiIsim.Name = "lblGonderiIsim";
            this.lblGonderiIsim.Size = new System.Drawing.Size(20, 17);
            this.lblGonderiIsim.TabIndex = 2;
            this.lblGonderiIsim.Text = "...";
            // 
            // btnResimSec
            // 
            this.btnResimSec.Location = new System.Drawing.Point(92, 21);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(129, 23);
            this.btnResimSec.TabIndex = 1;
            this.btnResimSec.Text = "Gönderi Seç";
            this.btnResimSec.UseVisualStyleBackColor = true;
            this.btnResimSec.Click += new System.EventHandler(this.BtnResimSec_Click);
            // 
            // lblResimSec
            // 
            this.lblResimSec.AutoSize = true;
            this.lblResimSec.Location = new System.Drawing.Point(3, 24);
            this.lblResimSec.Name = "lblResimSec";
            this.lblResimSec.Size = new System.Drawing.Size(83, 17);
            this.lblResimSec.TabIndex = 0;
            this.lblResimSec.Text = "Resim Seç: ";
            // 
            // Instagram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 343);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Instagram";
            this.Text = "Instagram";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPaylas;
        private System.Windows.Forms.Label lblGonderiIsim;
        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.Label lblResimSec;
    }
}