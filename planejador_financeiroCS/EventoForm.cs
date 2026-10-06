using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

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
            label1.Text = ucDia.static_day + "/" + frmMenuPrincipal.static_month + "/" + frmMenuPrincipal.static_year;
            textBox1.Text = label1.Text;
            //textBox1.Enabled = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var csb = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                Port = 3306,
                Database = "planejador_financeiro",
                UserID = "root",
                Password = "",
                SslMode = MySqlSslMode.Disabled // <-- changed from MySqlSslMode.None
            };
        
            using (var conn = new MySqlConnection(csb.ConnectionString))
            {
                conn.Open();
                const string sql = "INSERT INTO tbl_evento(data,evento) values (?,?)";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    DateTime data = DateTime.Parse(label1.Text);
                    //data = data.Replace(" ","");
                    cmd.Parameters.AddWithValue("data", data);
                    cmd.Parameters.AddWithValue("evento", textBox2.Text);
                    cmd.ExecuteNonQuery();
                }
            }
        
            MessageBox.Show("Salvo com sucesso!");
        }
    }
}
