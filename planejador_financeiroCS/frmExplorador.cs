using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using planejador_financeiroCS.Models;
using planejador_financeiroCS.Services;

namespace planejador_financeiroCS
{
    public partial class frmExplorador : Form
    {
        public frmExplorador()
        {
            Directory.CreateDirectory("Data");
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Example: add a test lancamento using the shared LancamentoStore
            var l = new Lancamento { Name = "teste", Value = 100m, Date = DateTime.Now, IsRecurringMonthly = false };
            LancamentoStore.Instance.AddOneTime(l.Name, l.Value, l.Tipo, l.Date);
            MessageBox.Show("Lancamento added to local store.");
        }
    }
}
