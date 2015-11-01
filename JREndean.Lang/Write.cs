

namespace JREndean.Lang
{
    using System;

    using JREndean.Lang.Continuations;

    public static class Write
    {
        public static WriteTextContinuation Text(string contents)
        {
            return new WriteTextContinuation(contents);
        }

        public static WriteTextContinuation Text(Func<string> inputMethod)
        {
            return new WriteTextContinuation(inputMethod());
        }

        public static WriteBytesContinuation Bytes(byte[] contents)
        {
            return new WriteBytesContinuation(contents);
        }

        public static WriteBytesContinuation Bytes(Func<byte[]> inputMethod)
        {
            return new WriteBytesContinuation(inputMethod());
        }

    }
}
