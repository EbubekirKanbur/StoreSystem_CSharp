
// MainForm.cs
// Ürün ve satış işlemlerinin yönetildiği ana panel

using System;
using System.Windows.Forms;

namespace StoreSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            // Yeni ürün ekleme işlemi
            MessageBox.Show("Yeni ürün eklendi.");
        }

        private void btnCalculateProfit_Click(object sender, EventArgs e)
        {
            // Kar/zarar hesaplama işlemi
            double totalIncome = 10000;
            double totalExpense = 7500;
            double profit = totalIncome - totalExpense;
            MessageBox.Show($"Toplam Kar: {profit} TL");
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            // Fatura gösterim ekranı
            InvoiceForm invoice = new InvoiceForm();
            invoice.Show();
        }
    }
}
