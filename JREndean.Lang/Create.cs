

namespace JREndean.Lang
{
    using System;

    using JREndean.Lang.Continuations;

    public static class Create
    {
        public static CreateNewContinuation New
        {
            get { return new CreateNewContinuation(); }
        }
    }
}
