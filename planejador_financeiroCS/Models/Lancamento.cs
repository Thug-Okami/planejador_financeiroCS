using System;

namespace planejador_financeiroCS.Models
{
    public class Lancamento
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Value { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        // If true, this lancamento repeats every month on Date.Day
        public bool IsRecurringMonthly { get; set; }
    }
}
