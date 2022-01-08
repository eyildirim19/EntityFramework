
namespace CrudApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnKategori = new System.Windows.Forms.Button();
            this.btnKullanici = new System.Windows.Forms.Button();
            this.btnNakliye = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKategori
            // 
            this.btnKategori.Location = new System.Drawing.Point(12, 12);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(172, 62);
            this.btnKategori.TabIndex = 0;
            this.btnKategori.Text = "Kategori İşlemleri";
            this.btnKategori.UseVisualStyleBackColor = true;
            this.btnKategori.Click += new System.EventHandler(this.btnKategori_Click);
            // 
            // btnKullanici
            // 
            this.btnKullanici.Location = new System.Drawing.Point(191, 13);
            this.btnKullanici.Name = "btnKullanici";
            this.btnKullanici.Size = new System.Drawing.Size(157, 61);
            this.btnKullanici.TabIndex = 1;
            this.btnKullanici.Text = "Kullanıcı İşlemleri";
            this.btnKullanici.UseVisualStyleBackColor = true;
            // 
            // btnNakliye
            // 
            this.btnNakliye.Location = new System.Drawing.Point(355, 13);
            this.btnNakliye.Name = "btnNakliye";
            this.btnNakliye.Size = new System.Drawing.Size(157, 61);
            this.btnNakliye.TabIndex = 2;
            this.btnNakliye.Text = "Nakliye İşlemleri";
            this.btnNakliye.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 327);
            this.Controls.Add(this.btnNakliye);
            this.Controls.Add(this.btnKullanici);
            this.Controls.Add(this.btnKategori);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKategori;
        private System.Windows.Forms.Button btnKullanici;
        private System.Windows.Forms.Button btnNakliye;
    }
}

