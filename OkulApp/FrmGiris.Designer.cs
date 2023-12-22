namespace OkulApp
{
    partial class FrmGiris
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
            this.lblgiris = new System.Windows.Forms.Label();
            this.btngirisogrencikayit = new System.Windows.Forms.Button();
            this.btngirisogretmenkayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblgiris
            // 
            this.lblgiris.AutoSize = true;
            this.lblgiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgiris.Location = new System.Drawing.Point(71, 48);
            this.lblgiris.Name = "lblgiris";
            this.lblgiris.Size = new System.Drawing.Size(252, 18);
            this.lblgiris.TabIndex = 0;
            this.lblgiris.Text = "Hangi İŞLEMİ YAPMAK İSTERSİNİZ?";
            // 
            // btngirisogrencikayit
            // 
            this.btngirisogrencikayit.Location = new System.Drawing.Point(104, 93);
            this.btngirisogrencikayit.Name = "btngirisogrencikayit";
            this.btngirisogrencikayit.Size = new System.Drawing.Size(177, 114);
            this.btngirisogrencikayit.TabIndex = 1;
            this.btngirisogrencikayit.Text = "Öğrenci Kayıt";
            this.btngirisogrencikayit.UseVisualStyleBackColor = true;
            this.btngirisogrencikayit.Click += new System.EventHandler(this.btngirisogrencikayit_Click);
            // 
            // btngirisogretmenkayit
            // 
            this.btngirisogretmenkayit.Location = new System.Drawing.Point(104, 239);
            this.btngirisogretmenkayit.Name = "btngirisogretmenkayit";
            this.btngirisogretmenkayit.Size = new System.Drawing.Size(177, 147);
            this.btngirisogretmenkayit.TabIndex = 2;
            this.btngirisogretmenkayit.Text = "Öğretmen Kayıt";
            this.btngirisogretmenkayit.UseVisualStyleBackColor = true;
            this.btngirisogretmenkayit.Click += new System.EventHandler(this.btngirisogretmenkayit_Click);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 450);
            this.Controls.Add(this.btngirisogretmenkayit);
            this.Controls.Add(this.btngirisogrencikayit);
            this.Controls.Add(this.lblgiris);
            this.Name = "FrmGiris";
            this.Text = "FrmGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblgiris;
        private System.Windows.Forms.Button btngirisogrencikayit;
        private System.Windows.Forms.Button btngirisogretmenkayit;
    }
}