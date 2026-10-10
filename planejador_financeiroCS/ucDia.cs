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
        string _day, _date, _weekday;

        public static string static_day, static_month, static_year;

        private void panel1_Click(object sender, EventArgs e)
        {
            // ensure static_day stores only the day number
            static_day = label1.Text.Split(' ')[0];
            timer1.Start();
            EventoForm eventform = new EventoForm();
            eventform.Show();
        }

        public ucDia(string day)
        {
            InitializeComponent();
            _day = day;
            label1.Text = day;
            _date = _day + "/" + frmMenuPrincipal._month + "/" + frmMenuPrincipal._year;
        }

        //Modifica as cores dos domingos
        private void sundays()
        {
            try
            {
                DateTime day = DateTime.Parse(_date);
                if (day.DayOfWeek == DayOfWeek.Sunday)
                    label1.ForeColor = Color.FromArgb(255, 128, 128);
                else
                    label1.ForeColor = Color.FromArgb(64, 64, 64);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        private void ucDia_Load(object sender, EventArgs e)
        {
            sundays();
        }

        //private void ucDia_Click(object sender, EventArgs e)
        //{
        //    static_day = label1.Text;
        //    EventoForm eventform = new EventoForm();
        //    eventform.Show();
        //}

        //private void displayEvents()
        private void displayEvents()
        {
            try
            {
                label2.Text = string.Empty;
                if (string.IsNullOrWhiteSpace(static_day)) return;
                if (!int.TryParse(static_day, out var dayNumber)) return;
                var month = frmMenuPrincipal.static_month;
                var year = frmMenuPrincipal.static_year;
                var lanc = LancamentoStore.Instance.GetLancamentosForMonth(month, year)
                    .Where(l => l.Date.Day == dayNumber)
                    .ToList();
                if (lanc.Count == 0) return;
                // show first two names or joined list
                var names = lanc.Select(l => l.Name).ToList();
                label2.Text = string.Join(", ", names.Take(3));
                if (names.Count > 3) label2.Text += ", ...";
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvents();
        }

        //
    }
}
