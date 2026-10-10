using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using planejador_financeiroCS.Models;

namespace planejador_financeiroCS.Services
{
    public class LancamentoStore
    {
        private readonly string _filePath;
        private readonly List<Lancamento> _items = new();

        private static LancamentoStore? _instance;
        public static LancamentoStore Instance => _instance ??= new LancamentoStore();

        public LancamentoStore()
        {
            var dataDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data");
            if (!Directory.Exists(dataDir)) Directory.CreateDirectory(dataDir);
            _filePath = Path.Combine(dataDir, "lancamentos.json");
            Load();
        }

        private void Load()
        {
            try
            {
                if (!File.Exists(_filePath)) return;
                var json = File.ReadAllText(_filePath);
                var items = JsonSerializer.Deserialize<List<Lancamento>>(json);
                if (items != null)
                {
                    _items.Clear();
                    _items.AddRange(items);
                }
            }
            catch
            {
                // ignore load errors for now
            }
        }

        private void Save()
        {
            try
            {
                var json = JsonSerializer.Serialize(_items, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(_filePath, json);
            }
            catch
            {
                // ignore save errors for now
            }
        }

        public IReadOnlyList<Lancamento> GetAll() => _items.AsReadOnly();

        // Adds a one-time lancamento
        public void AddOneTime(string name, decimal value, string tipo, DateTime date)
        {
            var item = new Lancamento {Id = Guid.NewGuid(), Name = name, Value = value, Tipo = tipo, Date = date, IsRecurringMonthly = false };
            _items.Add(item);
            Save();
        }

        // Adds a recurring monthly lancamento. Date.Day determines the day of month for occurrences.
        public void AddRecurringMonthly(string name, decimal value, string tipo, DateTime dateWithDay)
        {
            var item = new Lancamento {Id = Guid.NewGuid(), Name = name, Value = value, Tipo = tipo, Date = dateWithDay.Date, IsRecurringMonthly = true };
            _items.Add(item);
            Save();
        }

        // Returns lancamentos that apply to the specified month/year. Recurring entries are expanded to that month.
        public List<Lancamento> GetLancamentosForMonth(int month, int year)
        {
            var results = new List<Lancamento>();
            var oneTimes = _items.Where(x => !x.IsRecurringMonthly && x.Date.Month == month && x.Date.Year == year);
            results.AddRange(oneTimes);

            var recurring = _items.Where(x => x.IsRecurringMonthly);
            foreach (var r in recurring)
            {
                var day = r.Date.Day;
                var daysInMonth = DateTime.DaysInMonth(year, month);
                var actualDay = Math.Min(day, daysInMonth);
                var occurrenceDate = new DateTime(year, month, actualDay);
                results.Add(new Lancamento { Name = r.Name, Value = r.Value, Date = occurrenceDate, IsRecurringMonthly = true });
            }

            // sort by date
            return results.OrderBy(x => x.Date).ThenBy(x => x.Name).ToList();
        }
    }
}
