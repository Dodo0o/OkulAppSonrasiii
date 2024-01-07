namespace OkulApp
{
    partial class FrmOgrBul
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
            this.groupBoxOgrBul = new System.Windows.Forms.GroupBox();
            this.lblOgrNumara = new System.Windows.Forms.Label();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.groupBoxOgrBul.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOgrBul
            // 
            this.groupBoxOgrBul.Controls.Add(this.btnAra);
            this.groupBoxOgrBul.Controls.Add(this.txtNumara);
            this.groupBoxOgrBul.Controls.Add(this.lblOgrNumara);
            this.groupBoxOgrBul.Location = new System.Drawing.Point(12, 12);
            this.groupBoxOgrBul.Name = "groupBoxOgrBul";
            this.groupBoxOgrBul.Size = new System.Drawing.Size(213, 199);
            this.groupBoxOgrBul.TabIndex = 0;
            this.groupBoxOgrBul.TabStop = false;
            this.groupBoxOgrBul.Text = "Öğrenci Bulma Formu";
            // 
            // lblOgrNumara
            // 
            this.lblOgrNumara.AutoSize = true;
            this.lblOgrNumara.Location = new System.Drawing.Point(42, 44);
            this.lblOgrNumara.Name = "lblOgrNumara";
            this.lblOgrNumara.Size = new System.Drawing.Size(122, 13);
            this.lblOgrNumara.TabIndex = 0;
            this.lblOgrNumara.Text = "Öğrenci Numarası Giriniz";
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(54, 90);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(100, 20);
            this.txtNumara.TabIndex = 1;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(66, 139);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // FrmOgrBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 223);
            this.Controls.Add(this.groupBoxOgrBul);
            this.Name = "FrmOgrBul";
            this.Text = "FrmOgrBul";
            this.groupBoxOgrBul.ResumeLayout(false);
            this.groupBoxOgrBul.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOgrBul;
        private System.Windows.Forms.Label lblOgrNumara;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtNumara;
    }
}