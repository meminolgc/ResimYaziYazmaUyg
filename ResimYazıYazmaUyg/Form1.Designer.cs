namespace ResimYazıYazmaUyg
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.BtnRenkSec = new System.Windows.Forms.Button();
			this.BtnResimSec = new System.Windows.Forms.Button();
			this.BtnYazdır = new System.Windows.Forms.Button();
			this.BtnKaydet = new System.Windows.Forms.Button();
			this.LblMetinGir = new System.Windows.Forms.Label();
			this.TxtMetin = new System.Windows.Forms.TextBox();
			this.TxtBoyut = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// BtnRenkSec
			// 
			this.BtnRenkSec.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnRenkSec.Location = new System.Drawing.Point(12, 34);
			this.BtnRenkSec.Name = "BtnRenkSec";
			this.BtnRenkSec.Size = new System.Drawing.Size(198, 49);
			this.BtnRenkSec.TabIndex = 0;
			this.BtnRenkSec.Text = "Renk Seç";
			this.BtnRenkSec.UseVisualStyleBackColor = true;
			this.BtnRenkSec.Click += new System.EventHandler(this.BtnRenkSec_Click);
			// 
			// BtnResimSec
			// 
			this.BtnResimSec.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnResimSec.Location = new System.Drawing.Point(12, 92);
			this.BtnResimSec.Name = "BtnResimSec";
			this.BtnResimSec.Size = new System.Drawing.Size(198, 49);
			this.BtnResimSec.TabIndex = 5;
			this.BtnResimSec.Text = "Resim Seç";
			this.BtnResimSec.UseVisualStyleBackColor = true;
			this.BtnResimSec.Click += new System.EventHandler(this.BtnResimSec_Click);
			// 
			// BtnYazdır
			// 
			this.BtnYazdır.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnYazdır.Location = new System.Drawing.Point(12, 150);
			this.BtnYazdır.Name = "BtnYazdır";
			this.BtnYazdır.Size = new System.Drawing.Size(198, 49);
			this.BtnYazdır.TabIndex = 2;
			this.BtnYazdır.Text = "Yazdır";
			this.BtnYazdır.UseVisualStyleBackColor = true;
			this.BtnYazdır.Click += new System.EventHandler(this.BtnYazdır_Click);
			// 
			// BtnKaydet
			// 
			this.BtnKaydet.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnKaydet.Location = new System.Drawing.Point(12, 208);
			this.BtnKaydet.Name = "BtnKaydet";
			this.BtnKaydet.Size = new System.Drawing.Size(198, 49);
			this.BtnKaydet.TabIndex = 3;
			this.BtnKaydet.Text = "Kaydet";
			this.BtnKaydet.UseVisualStyleBackColor = true;
			this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
			// 
			// LblMetinGir
			// 
			this.LblMetinGir.AutoSize = true;
			this.LblMetinGir.BackColor = System.Drawing.Color.Transparent;
			this.LblMetinGir.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.LblMetinGir.ForeColor = System.Drawing.Color.White;
			this.LblMetinGir.Location = new System.Drawing.Point(15, 324);
			this.LblMetinGir.Name = "LblMetinGir";
			this.LblMetinGir.Size = new System.Drawing.Size(66, 18);
			this.LblMetinGir.TabIndex = 4;
			this.LblMetinGir.Text = "Metin :";
			// 
			// TxtMetin
			// 
			this.TxtMetin.Location = new System.Drawing.Point(84, 320);
			this.TxtMetin.Name = "TxtMetin";
			this.TxtMetin.Size = new System.Drawing.Size(126, 26);
			this.TxtMetin.TabIndex = 5;
			// 
			// TxtBoyut
			// 
			this.TxtBoyut.Location = new System.Drawing.Point(84, 357);
			this.TxtBoyut.Name = "TxtBoyut";
			this.TxtBoyut.Size = new System.Drawing.Size(126, 26);
			this.TxtBoyut.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(15, 361);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 18);
			this.label1.TabIndex = 6;
			this.label1.Text = "Boyut :";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(247, 34);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(503, 349);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// Form1
			// 
			this.AcceptButton = this.BtnKaydet;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(831, 458);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.TxtBoyut);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TxtMetin);
			this.Controls.Add(this.LblMetinGir);
			this.Controls.Add(this.BtnKaydet);
			this.Controls.Add(this.BtnYazdır);
			this.Controls.Add(this.BtnResimSec);
			this.Controls.Add(this.BtnRenkSec);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BtnRenkSec;
		private System.Windows.Forms.Button BtnResimSec;
		private System.Windows.Forms.Button BtnYazdır;
		private System.Windows.Forms.Button BtnKaydet;
		private System.Windows.Forms.Label LblMetinGir;
		private System.Windows.Forms.TextBox TxtMetin;
		private System.Windows.Forms.TextBox TxtBoyut;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.ColorDialog colorDialog1;
	}
}

