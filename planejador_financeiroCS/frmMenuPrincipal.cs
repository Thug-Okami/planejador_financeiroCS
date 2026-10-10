using System.Globalization;
using System.Linq;
using planejador_financeiroCS.Services;

namespace planejador_financeiroCS
{
    public partial class frmMenuPrincipal : Form
    {
        //variaveis para armazenar o mes e ano atual
        public static int _month, _year;

        //
        public static int static_month, static_year;

        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            showDays(DateTime.Now.Month, DateTime.Now.Year);
        }

        private void showDays(int month, int year)
        {
            flowLayoutPanel1.Controls.Clear();
            _year = year;
            _month = month;

            string monthName = new DateTimeFormatInfo().GetMonthName(month);
            lblMes.Text = monthName.ToUpper() + " " + year;

            //tutorial2
            static_month = _month;
            static_year = _year;
            //.

            DateTime startofTheMonth = new DateTime(year, month, 1);
            int day = DateTime.DaysInMonth(year, month);
            int week = Convert.ToInt32(startofTheMonth.DayOfWeek.ToString("d"));

            var lancamentos = LancamentoStore.Instance.GetLancamentosForMonth(month, year);
            for (int i = 1; i < week; i++)
            {
                ucDia uc = new ucDia("");
                flowLayoutPanel1.Controls.Add(uc);
            }
            for (int i = 1; i <= day; i++)
            {
                var count = lancamentos.Count(l => l.Date.Day == i);
                var label = count > 0 ? i + " (" + count + ")" : i + " ";
                ucDia uc = new ucDia(label);
                flowLayoutPanel1.Controls.Add(uc);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //tutorial2
            static_month = _month;
            static_year = _year;
            //.

            _month += 1;
            if (_month > 12)
            {
                _month = 1;
                _year += 1;
            }
            showDays(_month, _year);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            //tutorial2
            static_month = _month;
            static_year = _year;
            //.
            _month -= 1;
            if (_month < 1)
            {
                _month = 12;
                _year -= 1;
            }
            showDays(_month, _year);
        }

        private void btnMensal_Click(object sender, EventArgs e)
        {
            frmMensal open = new frmMensal();
            open.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmExplorador open = new frmExplorador();
            open.Show();
            this.Hide();
        }
    }
}
