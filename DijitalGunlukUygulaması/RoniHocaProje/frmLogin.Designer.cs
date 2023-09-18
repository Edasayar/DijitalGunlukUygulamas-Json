namespace RoniHocaProje
{
	partial class frmLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
			lblKullaniciAdi = new Label();
			lblSifre = new Label();
			txtKullaniciAdi = new TextBox();
			btnGirisYap = new Button();
			panel1 = new Panel();
			btnYeniKayitOlustur = new Button();
			lblDurum = new Label();
			btnGizle = new Button();
			txtSifre = new TextBox();
			dateTimePicker1 = new DateTimePicker();
			pictureBox1 = new PictureBox();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// lblKullaniciAdi
			// 
			lblKullaniciAdi.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblKullaniciAdi.ForeColor = Color.Black;
			lblKullaniciAdi.Location = new Point(16, 92);
			lblKullaniciAdi.Name = "lblKullaniciAdi";
			lblKullaniciAdi.Size = new Size(179, 45);
			lblKullaniciAdi.TabIndex = 0;
			lblKullaniciAdi.Text = "Kullanıcı Adı : ";
			// 
			// lblSifre
			// 
			lblSifre.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblSifre.Location = new Point(103, 156);
			lblSifre.Name = "lblSifre";
			lblSifre.Size = new Size(92, 43);
			lblSifre.TabIndex = 1;
			lblSifre.Text = "Şifre : ";
			// 
			// txtKullaniciAdi
			// 
			txtKullaniciAdi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtKullaniciAdi.Location = new Point(201, 96);
			txtKullaniciAdi.Name = "txtKullaniciAdi";
			txtKullaniciAdi.Size = new Size(200, 34);
			txtKullaniciAdi.TabIndex = 2;
			// 
			// btnGirisYap
			// 
			btnGirisYap.BackgroundImage = (Image)resources.GetObject("btnGirisYap.BackgroundImage");
			btnGirisYap.BackgroundImageLayout = ImageLayout.Stretch;
			btnGirisYap.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnGirisYap.Location = new Point(201, 221);
			btnGirisYap.Name = "btnGirisYap";
			btnGirisYap.Size = new Size(107, 46);
			btnGirisYap.TabIndex = 4;
			btnGirisYap.Text = "Giriş Yap";
			btnGirisYap.UseVisualStyleBackColor = true;
			btnGirisYap.Click += btnGirisYap_Click;
			// 
			// panel1
			// 
			panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
			panel1.BackgroundImageLayout = ImageLayout.Stretch;
			panel1.Controls.Add(btnYeniKayitOlustur);
			panel1.Controls.Add(lblDurum);
			panel1.Controls.Add(btnGizle);
			panel1.Controls.Add(txtSifre);
			panel1.Controls.Add(btnGirisYap);
			panel1.Controls.Add(lblKullaniciAdi);
			panel1.Controls.Add(txtKullaniciAdi);
			panel1.Controls.Add(lblSifre);
			panel1.Location = new Point(60, 35);
			panel1.Name = "panel1";
			panel1.Size = new Size(526, 370);
			panel1.TabIndex = 5;
			// 
			// btnYeniKayitOlustur
			// 
			btnYeniKayitOlustur.BackgroundImage = (Image)resources.GetObject("btnYeniKayitOlustur.BackgroundImage");
			btnYeniKayitOlustur.BackgroundImageLayout = ImageLayout.Stretch;
			btnYeniKayitOlustur.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btnYeniKayitOlustur.Location = new Point(314, 221);
			btnYeniKayitOlustur.Name = "btnYeniKayitOlustur";
			btnYeniKayitOlustur.Size = new Size(124, 46);
			btnYeniKayitOlustur.TabIndex = 9;
			btnYeniKayitOlustur.Text = "Yeni Kayıt Oluştur";
			btnYeniKayitOlustur.UseVisualStyleBackColor = true;
			btnYeniKayitOlustur.Click += btnYeniKayitOlustur_Click;
			// 
			// lblDurum
			// 
			lblDurum.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			lblDurum.Location = new Point(202, 270);
			lblDurum.Name = "lblDurum";
			lblDurum.Size = new Size(236, 37);
			lblDurum.TabIndex = 6;
			// 
			// btnGizle
			// 
			btnGizle.BackgroundImage = (Image)resources.GetObject("btnGizle.BackgroundImage");
			btnGizle.BackgroundImageLayout = ImageLayout.Stretch;
			btnGizle.Location = new Point(407, 160);
			btnGizle.Name = "btnGizle";
			btnGizle.Size = new Size(31, 29);
			btnGizle.TabIndex = 5;
			btnGizle.UseVisualStyleBackColor = true;
			btnGizle.MouseDown += btnGizle_MouseDown;
			btnGizle.MouseUp += btnGizle_MouseUp;
			// 
			// txtSifre
			// 
			txtSifre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtSifre.Location = new Point(202, 160);
			txtSifre.Name = "txtSifre";
			txtSifre.Size = new Size(200, 34);
			txtSifre.TabIndex = 3;
			txtSifre.TextChanged += txtSifre_TextChanged;
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(64, 411);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(191, 27);
			dateTimePicker1.TabIndex = 6;
			// 
			// pictureBox1
			// 
			pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
			pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
			pictureBox1.Location = new Point(39, 552);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(154, 136);
			pictureBox1.TabIndex = 7;
			pictureBox1.TabStop = false;
			// 
			// frmLogin
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(654, 746);
			Controls.Add(pictureBox1);
			Controls.Add(dateTimePicker1);
			Controls.Add(panel1);
			Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			Name = "frmLogin";
			Text = "Giriş Yap";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Label lblKullaniciAdi;
		private Label lblSifre;
		private TextBox txtKullaniciAdi;
		private Button btnGirisYap;
		private Panel panel1;
		private TextBox txtSifre;
		private Button btnGizle;
		private DateTimePicker dateTimePicker1;
		private PictureBox pictureBox1;
		private Label lblDurum;
		private Button btnYeniKayitOlustur;
	}
}