using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SailClubLibrary.Helpers.Filter
{
    public static class FilterFunctions
    {
        public static  List<T> Filter<T>(List<T> items, List<Predicate<T>> predicates)
        {
            if (predicates == null || predicates.Count == 0)
                return items; 
            foreach (var pre in predicates)
            {
                items = items.FindAll(pre);
            }
            return items;
        }
    }
}
