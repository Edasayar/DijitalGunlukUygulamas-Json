namespace RoniHocaProje
{
	partial class frmYeniKayitOlustur
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYeniKayitOlustur));
			txtYeniSifre = new TextBox();
			lblYeniKullanici = new Label();
			txtKYeniKullaniciAdi = new TextBox();
			lblSifre = new Label();
			b = new Button();
			button1 = new Button();
			SuspendLayout();
			// 
			// txtYeniSifre
			// 
			txtYeniSifre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtYeniSifre.Location = new Point(326, 220);
			txtYeniSifre.Margin = new Padding(3, 4, 3, 4);
			txtYeniSifre.Name = "txtYeniSifre";
			txtYeniSifre.Size = new Size(270, 34);
			txtYeniSifre.TabIndex = 12;
			// 
			// lblYeniKullanici
			// 
			lblYeniKullanici.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblYeniKullanici.ForeColor = Color.Black;
			lblYeniKullanici.Location = new Point(85, 157);
			lblYeniKullanici.Name = "lblYeniKullanici";
			lblYeniKullanici.Size = new Size(235, 38);
			lblYeniKullanici.TabIndex = 9;
			lblYeniKullanici.Text = "Yeni Kullanıcı Adı :";
			// 
			// txtKYeniKullaniciAdi
			// 
			txtKYeniKullaniciAdi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtKYeniKullaniciAdi.Location = new Point(326, 161);
			txtKYeniKullaniciAdi.Margin = new Padding(3, 4, 3, 4);
			txtKYeniKullaniciAdi.Name = "txtKYeniKullaniciAdi";
			txtKYeniKullaniciAdi.Size = new Size(270, 34);
			txtKYeniKullaniciAdi.TabIndex = 11;
			// 
			// lblSifre
			// 
			lblSifre.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblSifre.Location = new Point(174, 220);
			lblSifre.Name = "lblSifre";
			lblSifre.Size = new Size(146, 39);
			lblSifre.TabIndex = 10;
			lblSifre.Text = "Yeni Şifre : ";
			// 
			// b
			// 
			b.BackgroundImage = (Image)resources.GetObject("b.BackgroundImage");
			b.BackgroundImageLayout = ImageLayout.Stretch;
			b.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			b.Location = new Point(367, 262);
			b.Margin = new Padding(3, 4, 3, 4);
			b.Name = "b";
			b.Size = new Size(229, 61);
			b.TabIndex = 16;
			b.Text = "Yeni Kayıt Oluştur";
			b.UseVisualStyleBackColor = true;
			b.Click += button1_Click;
			// 
			// button1
			// 
			button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
			button1.BackgroundImageLayout = ImageLayout.Stretch;
			button1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			button1.Location = new Point(446, 435);
			button1.Margin = new Padding(3, 4, 3, 4);
			button1.Name = "button1";
			button1.Size = new Size(192, 49);
			button1.TabIndex = 17;
			button1.Text = "Giriş Sayfasına Dön";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click_1;
			// 
			// frmYeniKayitOlustur
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(726, 572);
			Controls.Add(button1);
			Controls.Add(b);
			Controls.Add(txtYeniSifre);
			Controls.Add(lblYeniKullanici);
			Controls.Add(txtKYeniKullaniciAdi);
			Controls.Add(lblSifre);
			Margin = new Padding(3, 4, 3, 4);
			Name = "frmYeniKayitOlustur";
			Text = "Yeni Kayıt Oluştur";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private TextBox txtYeniSifre;
		private Label lblYeniKullanici;
		private TextBox txtKYeniKullaniciAdi;
		private Label lblSifre;
		private Button b;
		private Button button1;
	}
}