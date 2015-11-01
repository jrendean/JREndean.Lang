

namespace JREndean.Lang.Continuations
{
    using JREndean.Lang.Chainings;

    public class ReadTextContinuation
    {
        public ReadFrom<string> From
        {
            get { return new ReadFrom<string>(ReadFrom<string>.Type.Text); }
        }
    }
}
