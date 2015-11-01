

namespace JREndean.Lang.Continuations
{
    using System;
    using System.Collections.Generic;

    using JREndean.Lang.Chainings;

    public class PickFromContinuation<TValue>
        : ResultsError<IEnumerable<TValue>, IEnumerable<TValue>>
    {
        private IEnumerable<TValue> values;

        public PickFromContinuation(IEnumerable<TValue> values)
            : base(values)
        {
            this.values = values;
        }

        public object When(TValue findValue)
        {
            // TODO: figure these out and write them

            return null;
        }

        public object Where(TValue findValue)
        {
            // TODO: figure these out and write them
            
            return null;
        }
    }
}
