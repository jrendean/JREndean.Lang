

namespace JREndean.Lang.Chainings
{
    using System;

    public abstract class VoidBase<TValue>
    {
        public VoidBase(TValue value)
        {
            this.Value = value;
        }

        public TValue Value
        {
            get;
            protected set;
        }
    }
}

