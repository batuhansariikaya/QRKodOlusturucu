
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRKodOlusturucu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void smplBtnOlustur_Click(object sender, EventArgs e)
        {
            if (txtEditMetin.Text==string.Empty)
            {
                MessageBox.Show("Boş QR Kod Oluşturamazsın", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string metin = txtEditMetin.Text;
                QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
                QRCodeData qRCodeData = qRCodeGenerator.CreateQrCode(metin, QRCodeGenerator.ECCLevel.H); // düzeltme katsayısı
                QRCode code = new QRCode(qRCodeData);
                Bitmap qrImage = code.GetGraphic(9);
                pctrQR.Image = qrImage;
            }
           


        }
    }
}
