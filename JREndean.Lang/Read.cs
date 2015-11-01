

namespace JREndean.Lang
{
    using JREndean.Lang.Continuations;

    public static class Read
    {
        public static ReadTextContinuation Text
        {
            get { return new ReadTextContinuation(); }
        }

        public static ReadBytesContinuation Bytes
        {
            get { return new ReadBytesContinuation(); }
        }

        public static ReadKeyContinuation Key
        {
            get { return new ReadKeyContinuation(); }
        }
    }
}
