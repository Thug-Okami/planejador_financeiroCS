using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace planejador_financeiroCS
{

    public partial class ucDia : UserControl
    {
        string connstring = "Server=localhost;Port=3306;Database=planejador_financeiro;UserID=root;Password=;SslMode = MySqlSslMode.Disabled;";
        string _day, _date, _weekday;

        public static string static_day, static_month, static_year;

        private void panel1_Click(object sender, EventArgs e)
        {
            static_day = label1.Text;
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

        private void displayEvents()
        {
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();
            String sql = "SELECT * FROM tbl_evento WHERE data = ?";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("data", ucDia.static_day + "/" + frmMenuPrincipal.static_month + "/" + frmMenuPrincipal.static_year + label2.Text);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                label2.Text = reader.GetString("evento");
            }
            reader.DisposeAsync();
            cmd.Dispose();
            conn.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvents();
        }

        //
    }
}
