using System;

namespace Sbt.Test.Refactoring.Base
{
    public abstract class FeatureBase
    {
        public FeatureBase(string keyword)
        {
            Keyword = keyword;
        }

        public string Keyword { get; }

        public bool Validate(string keyword)
        {
            return string.Equals(Keyword, keyword, StringComparison.OrdinalIgnoreCase);
        }

        public abstract void DoAction();
    }
}
