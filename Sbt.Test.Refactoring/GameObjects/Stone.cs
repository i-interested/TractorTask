using Sbt.Test.Refactoring.Base;
using Sbt.Test.Refactoring.Features;
using System.Collections.Generic;

namespace Sbt.Test.Refactoring.GameObjects
{
    public class Stone : GameObject
    {
        public Stone(Point startPosition, Size fieldSize) : base(new List<FeatureBase> { new PositionFeature(startPosition, fieldSize) })
        {
        }
        protected PositionFeature HasPositionFeature => (PositionFeature)Features[0];

        public int GetPositionX()
        {
            return HasPositionFeature.GetPositionX();
        }

        public int GetPositionY()
        {
            return HasPositionFeature.GetPositionY();
        }
    }
}
