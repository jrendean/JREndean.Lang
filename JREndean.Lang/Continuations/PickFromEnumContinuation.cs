

namespace JREndean.Lang.Continuations
{
    using System;
    using System.Collections.Generic;

    using JREndean.Lang.Chainings;

    public class PickFromEnumContinuation<TValue>
       : ResultsError<Type, TValue>
    {
        private Type enumType;

        public PickFromEnumContinuation(Type enumType)
            : base(enumType)
        {
            this.enumType = enumType;
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
