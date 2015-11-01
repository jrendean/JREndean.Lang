

namespace JREndean.Lang.Continuations
{
    using JREndean.Lang.Chainings;

    public class WriteBytesContinuation
    {
        private readonly byte[] contents;

        public WriteBytesContinuation(byte[] contents)
        {
            this.contents = contents;
        }

        public WriteTo<byte[]> To
        {
            get { return new WriteTo<byte[]>(WriteTo<byte[]>.Type.Bytes, this.contents); }
        }
    }
}
