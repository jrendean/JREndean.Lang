
namespace JREndean.Lang.Continuations
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class IfContinuation<TValue> 
    {
        private readonly TValue value;

        public IfContinuation(TValue value)
        {
            Is = new IsContinuation<TValue>(value, true);
            Does = new DoesContinuation<TValue>(value, true);

            this.value = value;
        }

        public JREndean.Lang.Chainings.IfThenElseVoid<TValue> Equals(TValue equal)
        {
            return new Chainings.IfThenElseVoid<TValue>(this.value, StringComparer.Create(System.Globalization.CultureInfo.InvariantCulture ,true).Compare(this.value, equal) == 0);
        }

        public IsContinuation<TValue> Is
        {
            get;
            private set;
        }

        //public IsContinuation<TValue> IsNot
        //{
        //    get;
        //    private set;
        //}

        public DoesContinuation<TValue> Does
        {
            get;
            private set;
        }

        //public DoesContinuation<TValue> DoesNot
        //{
        //    get;
        //    private set;
        //}
    }
}
