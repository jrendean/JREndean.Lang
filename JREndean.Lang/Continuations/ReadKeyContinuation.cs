

namespace JREndean.Lang.Continuations
{
    using System;

    using JREndean.Lang.Chainings;
    
    public class ReadKeyContinuation
    {
        public ReadFrom<ConsoleKeyInfo> From
        {
            get { return new ReadFrom<ConsoleKeyInfo>(ReadFrom<ConsoleKeyInfo>.Type.Key); }
        }
    }
}
