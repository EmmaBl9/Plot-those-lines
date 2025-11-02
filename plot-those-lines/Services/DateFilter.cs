///ETML
///Auteur : [Ton Nom]
///Date   : [Date du jour]
///Description : Classe permettant de filtrer des dates selon une plage définie.

using System;

namespace plot_those_lines.Services
{
    /// <summary>
    /// Gère un filtre de dates avec une année de début et de fin optionnelles.
    /// </summary>
    public class DateFilter
    {
        public int? StartYear { get; private set; }
        public int? EndYear { get; private set; }

        public event Action? OnFilterChanged;

        /// <summary>
        /// Définit une plage de dates.
        /// </summary>
        /// <param name="startYear">Année de début.</param>
        /// <param name="endYear">Année de fin.</param>
        public void SetDateRange(int? startYear, int? endYear)
        {
            StartYear = startYear;
            EndYear = endYear;
            OnFilterChanged?.Invoke();
        }

        /// <summary>
        /// Supprime le filtre de dates.
        /// </summary>
        public void ClearFilter()
        {
            StartYear = null;
            EndYear = null;
            OnFilterChanged?.Invoke();
        }

        /// <summary>
        /// Vérifie si une année donnée est dans la plage du filtre.
        /// </summary>
        /// <param name="year">Année à tester.</param>
        /// <returns>Vrai si l'année est comprise dans la plage, sinon faux.</returns>
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
