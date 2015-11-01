

namespace JREndean.Lang.Chainings
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public class FindOrListFrom 
        : ResultsError<string, IEnumerable<string>>
    {
        public FindOrListFrom(string path)
            : base(path)
        {
        }

        public FindOrListFrom Matching(string pattern)
        {
            // TODO: 
            return this;
        }

        //public static implicit operator IEnumerable<string>(FindOrListFrom obj)
        //{
        //    return obj.Results;
        //}
    }
}
