

namespace JREndean.Lang.Extensions
{
    using JREndean.Lang.Continuations;

    public static class Number
    {
        public static IsContinuation<int> Is(this int value)
        {
            return new IsContinuation<int>(value, true);
        }
    }
}
