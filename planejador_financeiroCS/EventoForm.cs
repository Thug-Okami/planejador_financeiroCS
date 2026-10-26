using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using planejador_financeiroCS.Services;

namespace planejador_financeiroCS
{
    public partial class EventoForm : Form
    {
        //create a connectionstring
        //string connString = "Server=localhost;Port=3306;Database=planejador_financeiro;Uid=root;Pwd=;SslMode=None;";


        private readonly DateTime _data;

        public EventoForm(DateTime data)
        {
            InitializeComponent();
            _data = data.Date;
        }

        private void EventoForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = _data.ToString("dd/MM/yyyy");
            textBox1.Enabled = false;
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime data = _data;
                if (!decimal.TryParse(textBoxValor.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out decimal valor))
                {
                    MessageBox.Show("Valor inválido.");
                    return;
                }
                if (checkBoxRecurring != null && checkBoxRecurring.Checked)
                {
                    LancamentoStore.Instance.AddRecurringMonthly(textBoxNome.Text ?? string.Empty, valor, comboBoxTipo.SelectedItem?.ToString() ?? string.Empty, data);
                }
                else
                {
                    LancamentoStore.Instance.AddOneTime(textBoxNome.Text ?? string.Empty, valor, comboBoxTipo.SelectedItem?.ToString() ?? string.Empty, data);
                }

                MessageBox.Show("Salvo com sucesso!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
        }


    }
}
