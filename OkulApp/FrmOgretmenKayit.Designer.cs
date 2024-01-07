namespace OkulApp
{
    partial class FrmOgretmenKayit
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
            this.grpOgretmenKayit = new System.Windows.Forms.GroupBox();
            this.btnOgretmenKaydet = new System.Windows.Forms.Button();
            this.txtOgretmenTCKimlik = new System.Windows.Forms.TextBox();
            this.txtOgretmenSoyad = new System.Windows.Forms.TextBox();
            this.txtOgretmenAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOgretmenBul = new System.Windows.Forms.Button();
            this.btnOgretmenSil = new System.Windows.Forms.Button();
            this.btnOgretmenGuncelle = new System.Windows.Forms.Button();
            this.grpOgretmenKayit.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOgretmenKayit
            // 
            this.grpOgretmenKayit.Controls.Add(this.btnOgretmenKaydet);
            this.grpOgretmenKayit.Controls.Add(this.txtOgretmenTCKimlik);
            this.grpOgretmenKayit.Controls.Add(this.txtOgretmenSoyad);
            this.grpOgretmenKayit.Controls.Add(this.txtOgretmenAd);
            this.grpOgretmenKayit.Controls.Add(this.label3);
            this.grpOgretmenKayit.Controls.Add(this.label2);
            this.grpOgretmenKayit.Controls.Add(this.label1);
            this.grpOgretmenKayit.Location = new System.Drawing.Point(28, 24);
            this.grpOgretmenKayit.Name = "grpOgretmenKayit";
            this.grpOgretmenKayit.Size = new System.Drawing.Size(414, 379);
            this.grpOgretmenKayit.TabIndex = 0;
            this.grpOgretmenKayit.TabStop = false;
            this.grpOgretmenKayit.Text = "Öğretmen Kayıt";
            // 
            // btnOgretmenKaydet
            // 
            this.btnOgretmenKaydet.Location = new System.Drawing.Point(144, 281);
            this.btnOgretmenKaydet.Name = "btnOgretmenKaydet";
            this.btnOgretmenKaydet.Size = new System.Drawing.Size(137, 65);
            this.btnOgretmenKaydet.TabIndex = 6;
            this.btnOgretmenKaydet.Text = "Kaydet";
            this.btnOgretmenKaydet.UseVisualStyleBackColor = true;
            this.btnOgretmenKaydet.Click += new System.EventHandler(this.btnOgretmenKaydet_Click);
            // 
            // txtOgretmenTCKimlik
            // 
            this.txtOgretmenTCKimlik.Location = new System.Drawing.Point(181, 223);
            this.txtOgretmenTCKimlik.Name = "txtOgretmenTCKimlik";
            this.txtOgretmenTCKimlik.Size = new System.Drawing.Size(100, 20);
            this.txtOgretmenTCKimlik.TabIndex = 5;
            // 
            // txtOgretmenSoyad
            // 
            this.txtOgretmenSoyad.Location = new System.Drawing.Point(181, 144);
            this.txtOgretmenSoyad.Name = "txtOgretmenSoyad";
            this.txtOgretmenSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtOgretmenSoyad.TabIndex = 4;
            // 
            // txtOgretmenAd
            // 
            this.txtOgretmenAd.Location = new System.Drawing.Point(181, 50);
            this.txtOgretmenAd.Name = "txtOgretmenAd";
            this.txtOgretmenAd.Size = new System.Drawing.Size(100, 20);
            this.txtOgretmenAd.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "T.C Kimlik Numarası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // btnOgretmenBul
            // 
            this.btnOgretmenBul.Location = new System.Drawing.Point(500, 53);
            this.btnOgretmenBul.Name = "btnOgretmenBul";
            this.btnOgretmenBul.Size = new System.Drawing.Size(75, 23);
            this.btnOgretmenBul.TabIndex = 0;
            this.btnOgretmenBul.Text = "BUL";
            this.btnOgretmenBul.UseVisualStyleBackColor = true;
            this.btnOgretmenBul.Click += new System.EventHandler(this.btnOgretmenBul_Click);
            // 
            // btnOgretmenSil
            // 
            this.btnOgretmenSil.Enabled = false;
            this.btnOgretmenSil.Location = new System.Drawing.Point(500, 129);
            this.btnOgretmenSil.Name = "btnOgretmenSil";
            this.btnOgretmenSil.Size = new System.Drawing.Size(75, 23);
            this.btnOgretmenSil.TabIndex = 1;
            this.btnOgretmenSil.Text = "Sil";
            this.btnOgretmenSil.UseVisualStyleBackColor = true;
            this.btnOgretmenSil.Click += new System.EventHandler(this.btnOgretmenSil_Click);
            // 
            // btnOgretmenGuncelle
            // 
            this.btnOgretmenGuncelle.Enabled = false;
            this.btnOgretmenGuncelle.Location = new System.Drawing.Point(500, 208);
            this.btnOgretmenGuncelle.Name = "btnOgretmenGuncelle";
            this.btnOgretmenGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnOgretmenGuncelle.TabIndex = 2;
            this.btnOgretmenGuncelle.Text = "Güncelle";
            this.btnOgretmenGuncelle.UseVisualStyleBackColor = true;
            this.btnOgretmenGuncelle.Click += new System.EventHandler(this.btnOgretmenGuncelle_Click);
            // 
            // FrmOgretmenKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 450);
            this.Controls.Add(this.btnOgretmenGuncelle);
            this.Controls.Add(this.btnOgretmenSil);
            this.Controls.Add(this.btnOgretmenBul);
            this.Controls.Add(this.grpOgretmenKayit);
            this.Name = "FrmOgretmenKayit";
            this.Text = "FrmOgretmenKayit";
            this.grpOgretmenKayit.ResumeLayout(false);
            this.grpOgretmenKayit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOgretmenKayit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOgretmenKaydet;
        private System.Windows.Forms.Button btnOgretmenBul;
        public System.Windows.Forms.Button btnOgretmenSil;
        public System.Windows.Forms.Button btnOgretmenGuncelle;
        public System.Windows.Forms.TextBox txtOgretmenTCKimlik;
        public System.Windows.Forms.TextBox txtOgretmenSoyad;
        public System.Windows.Forms.TextBox txtOgretmenAd;
    }
}