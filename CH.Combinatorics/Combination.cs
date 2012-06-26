using System;
using System.Collections.Generic;
using System.Linq;

namespace CH.Combinatorics
{
    public static class Combination
    {
        public static IEnumerable<IEnumerable<T>> Choose<T>(this IEnumerable<T> enumerable, int count,
                                                            bool replace = false)
        {
            var concEnumerable = enumerable.ToArray();
            if (count <= 0) throw new ArgumentException("count must be more than 0", "count");
            if (concEnumerable.Length == 0)
                throw new ArgumentException("enumerable must contain elements", "enumerable");

            if (concEnumerable.Length == count)
            {
                yield return concEnumerable;
            }
            else
            {
                for (var index = 0; index < concEnumerable.Length; ++index)
                {
                    // remove i from first and make it first in the result, append the remaining choices from the remaining elements
                    var newFirst = concEnumerable[index];
                    if (count == 1)
                    {
                        yield return new[] {newFirst};
                    }
                    else
                    {
                        var subSet =
                            replace
                                ? concEnumerable
                                : concEnumerable.AllExceptAt(index);

                        foreach (var subChoose in Choose(subSet, count - 1))
                            yield return new[] {newFirst}.Concat(subChoose);
                    }
                }
            }
        }
    }
}