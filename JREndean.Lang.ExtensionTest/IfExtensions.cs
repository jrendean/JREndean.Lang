


namespace JREndean.Lang.Extensions
{
    using System;

    using JREndean.Lang.Chainings;
    using JREndean.Lang.Continuations;

    public static partial class IfExtensions
    {
        public static IfThenElseVoid<TValue> NotNull<TValue>(this IsContinuation<TValue> item)
        {
            //try
            //{
            //    return new IfThenElseVoid<TValue>(item.value, (item.value != null) == item.truth);
            //}
            //catch (Exception ex)
            //{
            //    return new IfThenElseVoid<TValue>(item.value, ex);
            //}

            return null;
        }
    }
}
