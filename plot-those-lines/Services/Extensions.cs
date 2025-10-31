using System;
using System.Collections.Generic;

namespace plot_those_lines.Services
{
    // Extensions 1 permettant d'arrondir un nombre decimal
    public static class DecimalExtensions
    {
        public static decimal? RoundTo2(this decimal? value)
        {
            return value.HasValue ? Math.Round(value.Value, 2) : null;
        }
    }

    //Extensions 2 permettant de vérifier si la liste est vide
    public static class ListExtensions
    {
        public static bool IsEmpty<T>(this List<T> list)
        {
            return list == null || list.Count == 0;
        }
    }
}