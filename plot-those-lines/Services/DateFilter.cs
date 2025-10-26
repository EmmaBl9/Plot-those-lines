using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plot_those_lines.Services
{
    public class DateFilter
    {
        public int? StartYear { get; private set; }
        public int? EndYear { get; private set; }

        public event Action? OnFilterChanged;

        public void SetDateRange(int? startYear, int? endYear)
        {
            StartYear = startYear;
            EndYear = endYear;
            OnFilterChanged?.Invoke();
        }

        public void ClearFilter()
        {
            StartYear = null;
            EndYear = null;
            OnFilterChanged?.Invoke();
        }

        public bool IsYearInRange(string year)
        {
            if (!int.TryParse(year, out var yearInt))
                return true;

            if (StartYear.HasValue && yearInt < StartYear.Value)
                return false;

            if (EndYear.HasValue && yearInt > EndYear.Value)
                return false;

            return true;
        }
    }
}
