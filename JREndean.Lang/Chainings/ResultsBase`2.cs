

namespace JREndean.Lang.Chainings
{
    using System;
       
    public abstract class ResultsBase<TValue, TOutput>
        : VoidBase<TValue>
    {
        public ResultsBase(TValue value)
            : base(value)
        {
        }

        public TOutput Results
        {
            get;
            protected set;
        }

        public TNewOutput TransformResults<TNewOutput>(Func<TOutput, TNewOutput> re)
        {
            return re(this.Results);
        }

        public static implicit operator TOutput(ResultsBase<TValue, TOutput> obj)
        {
            return obj.Results;
        }
    }
}

