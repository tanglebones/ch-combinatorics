using System.Collections.Generic;
using System.Linq;

namespace CH.Combinatorics
{
    public static class Filter
    {
        public static IEnumerable<T> AllExceptAt<T>(this IEnumerable<T> enumerable, int index)
        {
            return enumerable.Where((_, i) => i != index);
        } 
    }
}