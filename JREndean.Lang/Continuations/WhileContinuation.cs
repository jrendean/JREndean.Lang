

namespace JREndean.Lang.Continuations
{
    using System;
    using JREndean.Lang.Chainings;

    public class WhileContinuation
        : VoidError
    {
        private readonly Action theAction;

        public WhileContinuation(Action theAction)
        {
            this.theAction = theAction;
        }

        public void True(Func<bool> doTillTrueFunc)
        {
            try
            {
                if (!this.HasError)
                {
                    while (doTillTrueFunc() != true)
                    {
                        this.theAction();
                    }
                }
            }
            catch (Exception ex)
            {
                this.Exception = ex;
            }
        }

        public void False(Func<bool> doTillTrueFunc)
        {
            try
            {
                if (!this.HasError)
                {
                    while (doTillTrueFunc() != false)
                    {
                        this.theAction();
                    }
                }
            }
            catch (Exception ex)
            {
                this.Exception = ex;
            }
        }
    }
}
