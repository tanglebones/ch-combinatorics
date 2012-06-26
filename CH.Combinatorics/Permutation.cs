using System.Collections.Generic;
using System.Linq;

namespace CH.Combinatorics
{
    public static class Permutation
    {
        public static IEnumerable<IEnumerable<T>> Permute<T>(this IEnumerable<T> enumerable)
        {
            var concEnumerable = enumerable.ToArray();

            if (concEnumerable.Length == 1)
            {
                yield return concEnumerable;
            }
            else
            {
                for (var index = 0; index < concEnumerable.Length; ++index)
                {
                    // remove i from first and make it first in the result, append the permutations of the remaining elements
                    var newFirst = concEnumerable[index];
                    var subSet = concEnumerable.AllExceptAt(index);
                    foreach (var subPermute in Permute(subSet))
                        yield return new[] {newFirst}.Concat(subPermute);
                }
            }
        }
    }
}