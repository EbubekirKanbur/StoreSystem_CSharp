
// InvoiceForm.cs
// Satış sonrası fatura gösterim ve yazdırma ekranı

using System;
using System.Windows.Forms;

namespace StoreSystem
{
    public partial class InvoiceForm : Form
    {
        public InvoiceForm()
        {
            InitializeComponent();
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            // Sahte fatura örneği göster
            txtInvoice.Text = "FATURA\nÜrün: Kalem\nAdet: 10\nToplam: 200 TL";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Yazdırma işlemi (temsilî)
            MessageBox.Show("Fatura yazdırılıyor...");
        }
    }
}
