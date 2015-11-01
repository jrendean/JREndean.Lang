

namespace JREndean.Lang
{
    using JREndean.Lang.Continuations;

    public static class Find
    {
        public static FindOrListContinuation Files
        {
            get { return new FindOrListContinuation(FindOrListContinuation.Type.Files); }
        }

        public static FindOrListContinuation Folders
        {
            get { return new FindOrListContinuation(FindOrListContinuation.Type.Folders); }
        }
    }
}
