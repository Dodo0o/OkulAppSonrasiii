namespace OkulApp
{
    partial class FrmOgretmenBul
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
            this.grpboxOgretmenBul = new System.Windows.Forms.GroupBox();
            this.lblTCKimlikBul = new System.Windows.Forms.Label();
            this.txtOgretmenTCKimlik = new System.Windows.Forms.TextBox();
            this.btnOgretmenAra = new System.Windows.Forms.Button();
            this.grpboxOgretmenBul.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpboxOgretmenBul
            // 
            this.grpboxOgretmenBul.Controls.Add(this.btnOgretmenAra);
            this.grpboxOgretmenBul.Controls.Add(this.txtOgretmenTCKimlik);
            this.grpboxOgretmenBul.Controls.Add(this.lblTCKimlikBul);
            this.grpboxOgretmenBul.Location = new System.Drawing.Point(13, 13);
            this.grpboxOgretmenBul.Name = "grpboxOgretmenBul";
            this.grpboxOgretmenBul.Size = new System.Drawing.Size(242, 190);
            this.grpboxOgretmenBul.TabIndex = 0;
            this.grpboxOgretmenBul.TabStop = false;
            this.grpboxOgretmenBul.Text = "Öğretmen Bulma Formu";
            // 
            // lblTCKimlikBul
            // 
            this.lblTCKimlikBul.AutoSize = true;
            this.lblTCKimlikBul.Location = new System.Drawing.Point(79, 50);
            this.lblTCKimlikBul.Name = "lblTCKimlikBul";
            this.lblTCKimlikBul.Size = new System.Drawing.Size(85, 13);
            this.lblTCKimlikBul.TabIndex = 0;
            this.lblTCKimlikBul.Text = "T.C Kimlik Giriniz";
            // 
            // txtOgretmenTCKimlik
            // 
            this.txtOgretmenTCKimlik.Location = new System.Drawing.Point(57, 91);
            this.txtOgretmenTCKimlik.Name = "txtOgretmenTCKimlik";
            this.txtOgretmenTCKimlik.Size = new System.Drawing.Size(137, 20);
            this.txtOgretmenTCKimlik.TabIndex = 1;
            // 
            // btnOgretmenAra
            // 
            this.btnOgretmenAra.Location = new System.Drawing.Point(82, 153);
            this.btnOgretmenAra.Name = "btnOgretmenAra";
            this.btnOgretmenAra.Size = new System.Drawing.Size(75, 23);
            this.btnOgretmenAra.TabIndex = 2;
            this.btnOgretmenAra.Text = "Ara";
            this.btnOgretmenAra.UseVisualStyleBackColor = true;
            this.btnOgretmenAra.Click += new System.EventHandler(this.btnOgretmenAra_Click);
            // 
            // FrmOgretmenBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 217);
            this.Controls.Add(this.grpboxOgretmenBul);
            this.Name = "FrmOgretmenBul";
            this.Text = "FrmOgretmenBul";
            this.grpboxOgretmenBul.ResumeLayout(false);
            this.grpboxOgretmenBul.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxOgretmenBul;
        private System.Windows.Forms.Button btnOgretmenAra;
        private System.Windows.Forms.TextBox txtOgretmenTCKimlik;
        private System.Windows.Forms.Label lblTCKimlikBul;
    }
}