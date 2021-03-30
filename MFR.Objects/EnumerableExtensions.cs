using System;
using System.Collections.Generic;

namespace MFR.Objects
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> TakeAllButLast<T>(
            this IEnumerable<T> source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            using (var it = source.GetEnumerator())
            {
                var hasRemainingItems = false;
                var isFirst = true;
                var item = default(T);

                do
                {
                    hasRemainingItems = it.MoveNext();
                    if (hasRemainingItems)
                    {
                        if (!isFirst) yield return item;
                        item = it.Current;
                        isFirst = false;
                    }
                } while (hasRemainingItems);
            }
        }
    }
}