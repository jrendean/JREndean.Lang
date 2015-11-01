
namespace JREndean.Lang.Continuations
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class IfContinuation<TValue, TOutput>
    {
        public IfContinuation(TValue value)
        {
            Is = new IsContinuation<TValue, TOutput>(value, true);
            //IsNot = new IsContinuation<TValue, TOutput>(value, false);

            Does = new DoesContinuation<TValue, TOutput>(value, true);
            //DoesNot = new DoesContinuation<TValue, TOutput>(value, false);
        }

        public IsContinuation<TValue, TOutput> Is
        {
            get;
            private set;
        }

        //public IsContinuation<TValue, TOutput> IsNot
        //{
        //    get;
        //    private set;
        //}

        public DoesContinuation<TValue, TOutput> Does
        {
            get;
            private set;
        }

        //public DoesContinuation<TValue, TOutput> DoesNot
        //{
        //    get;
        //    private set;
        //}
    }
}
