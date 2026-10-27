using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using planejador_financeiroCS.Services;

namespace planejador_financeiroCS
{

    public partial class ucDia : UserControl
    {
        // null = célula vazia (preenchimento antes do dia 1)
        private readonly DateTime? _date;

        private void panel1_Click(object sender, EventArgs e)
        {
            if (_date == null) return;
            using (var eventform = new EventoForm(_date.Value))
            {
                eventform.ShowDialog(this);
            }
            displayEvents();
        }

        public ucDia(DateTime? date)
        {
            InitializeComponent();
            _date = date;
        }

        //Modifica as cores dos domingos
        private void sundays()
        {
            if (_date == null) return;
            if (_date.Value.DayOfWeek == DayOfWeek.Sunday)
                label1.ForeColor = Color.FromArgb(255, 128, 128);
            else
                label1.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void ucDia_Load(object sender, EventArgs e)
        {
            sundays();
            displayEvents();
        }

        private void displayEvents()
        {
            label1.Text = string.Empty;
            label2.Text = string.Empty;
            if (_date == null) return;

            var date = _date.Value;
            label1.Text = date.Day.ToString();
            try
            {
                var lanc = LancamentoStore.Instance.GetLancamentosForMonth(date.Month, date.Year)
                    .Where(l => l.Date.Day == date.Day)
                    .ToList();
                if (lanc.Count == 0) return;
                label1.Text += " (" + lanc.Count + ")";
                // show first three names
                var names = lanc.Select(l => l.Name).ToList();
                label2.Text = string.Join(", ", names.Take(3));
                if (names.Count > 3) label2.Text += ", ...";
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}
