///ETML
///Auteur : [Ton Nom]
///Date   : [Date du jour]
///Description : Classes d’extensions pour les types decimal et List.

using System;
using System.Collections.Generic;

namespace plot_those_lines.Services
{
    /// <summary>
    /// Extensions pour le type decimal.
    /// </summary>
    public static class DecimalExtensions
    {
        /// <summary>
        /// Arrondit une valeur décimale à deux chiffres après la virgule.
        /// </summary>
        /// <param name="value">Valeur décimale à arrondir.</param>
        /// <returns>Valeur arrondie ou null si non définie.</returns>
        public static decimal? RoundTo2(this decimal? value)
        {
            return value.HasValue ? Math.Round(value.Value, 2) : null;
        }
    }

    /// <summary>
    /// Extensions pour le type List.
    /// </summary>
    public static class ListExtensions
    {
        /// <summary>
        /// Indique si la liste est vide ou nulle.
        /// </summary>
        /// <typeparam name="T">Type des éléments de la liste.</typeparam>
        /// <param name="list">Liste à vérifier.</param>
        /// <returns>Vrai si la liste est vide ou nulle, sinon faux.</returns>
        public static bool IsEmpty<T>(this List<T> list)
        {
            return list == null || list.Count == 0;
        }
    }
}
