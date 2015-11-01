

namespace JREndean.Lang.Continuations
{
    using JREndean.Lang.Chainings;

    public class ReadBytesContinuation
    {
        public ReadFrom<byte[]> From
        {
            get { return new ReadFrom<byte[]>(ReadFrom<byte[]>.Type.Bytes); }
        }
    }
}
