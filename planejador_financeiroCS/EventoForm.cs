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


        public EventoForm()
        {
            InitializeComponent();
        }

        private void EventoForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = ucDia.static_day + "/" + frmMenuPrincipal.static_month + "/" + frmMenuPrincipal.static_year;
            textBox1.Enabled = false;
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime data = DateTime.Parse(textBox1.Text);
                decimal valor = decimal.Parse(textBoxValor.Text); // default value for now, can be extended to allow user input
                // Use LancamentoStore; store event text as Name and Value=0 for now
                if (checkBoxRecurring != null && checkBoxRecurring.Checked)
                {
                    LancamentoStore.Instance.AddRecurringMonthly(textBoxNome.Text ?? string.Empty, valor, comboBoxTipo.SelectedItem?.ToString() ?? string.Empty, data);
                }
                else
                {
                    LancamentoStore.Instance.AddOneTime(textBoxNome.Text ?? string.Empty, valor, comboBoxTipo.SelectedItem?.ToString() ?? string.Empty, data);
                }

                MessageBox.Show("Salvo com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
        }


    }
}
