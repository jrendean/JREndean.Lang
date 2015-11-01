

namespace JREndean.Lang
{
    using JREndean.Lang.Continuations;

    public static class If
    {
        public static IfContinuation<TValue> Value<TValue>(TValue value)
        {
            return new IfContinuation<TValue>(value);
        }

        public static IfContinuation<TValue, TOutput?> Value<TValue, TOutput>(TValue value) where TOutput : struct
        {
            return new IfContinuation<TValue, TOutput?>(value);
        }

        public static IfContinuation<TValue> Value<TValue>(System.Func<TValue> valueRetriever)
        {
            return new IfContinuation<TValue>(valueRetriever());
        }


        public static IfContinuation<TValue> Argument<TValue>(TValue value)
        {
            return new IfContinuation<TValue>(value);
        }

        public static IfContinuation<TValue, TOutput?> Argument<TValue, TOutput>(TValue value) where TOutput : struct
        {
            return new IfContinuation<TValue, TOutput?>(value);
        }


        public static IfContinuation<TValue> This<TValue>(TValue value)
        {
            return new IfContinuation<TValue>(value);
        }

        public static IfContinuation<TValue, TOutput?> This<TValue, TOutput>(TValue value) where TOutput : struct
        {
            return new IfContinuation<TValue, TOutput?>(value);
        }

        public static IfContinuation<TValue> This<TValue>(System.Func<TValue> valueRetriever)
        {
            return new IfContinuation<TValue>(valueRetriever());
        }
    }
}
