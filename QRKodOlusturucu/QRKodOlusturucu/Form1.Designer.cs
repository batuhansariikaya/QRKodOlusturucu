namespace QRKodOlusturucu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.pctrQR = new System.Windows.Forms.PictureBox();
            this.smplBtnOlustur = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtEditMetin = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrQR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditMetin.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pctrQR
            // 
            this.pctrQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctrQR.Location = new System.Drawing.Point(12, 140);
            this.pctrQR.Name = "pctrQR";
            this.pctrQR.Size = new System.Drawing.Size(307, 245);
            this.pctrQR.TabIndex = 0;
            this.pctrQR.TabStop = false;
            // 
            // smplBtnOlustur
            // 
            this.smplBtnOlustur.Location = new System.Drawing.Point(12, 106);
            this.smplBtnOlustur.Name = "smplBtnOlustur";
            this.smplBtnOlustur.Size = new System.Drawing.Size(307, 28);
            this.smplBtnOlustur.TabIndex = 2;
            this.smplBtnOlustur.Text = "OLUŞTUR";
            this.smplBtnOlustur.Click += new System.EventHandler(this.smplBtnOlustur_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Open Sans Semibold", 20F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(21, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(290, 37);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "QR KOD OLUŞTURUCU";
            // 
            // txtEditMetin
            // 
            this.txtEditMetin.Location = new System.Drawing.Point(12, 80);
            this.txtEditMetin.Name = "txtEditMetin";
            this.txtEditMetin.Size = new System.Drawing.Size(307, 20);
            this.txtEditMetin.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 397);
            this.Controls.Add(this.txtEditMetin);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.smplBtnOlustur);
            this.Controls.Add(this.pctrQR);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "www.batuhansarikaya.com";
            ((System.ComponentModel.ISupportInitialize)(this.pctrQR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditMetin.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctrQR;
        private DevExpress.XtraEditors.SimpleButton smplBtnOlustur;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtEditMetin;
    }
}

