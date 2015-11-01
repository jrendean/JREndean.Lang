

namespace JREndean.Lang
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    using JREndean.Lang.Continuations;

    public static class Pick
    {
        public static PickFromContinuation<TValue> From<TValue>(IEnumerable<TValue> values) //where TValue : IEnumerable<TValue>
        {
            return new PickFromContinuation<TValue>(values);
        }

        public static PickFromEnumContinuation<TEnum> From<TEnum>() where TEnum : struct, IConvertible, IFormattable, IComparable
        {
            return new PickFromEnumContinuation<TEnum>(typeof(TEnum));
        }
    }
}
