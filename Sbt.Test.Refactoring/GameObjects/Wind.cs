using Sbt.Test.Refactoring.Base;
using Sbt.Test.Refactoring.Features;
using System.Collections.Generic;

namespace Sbt.Test.Refactoring.GameObjects
{
    public class Wind : GameObject
    {
        public Wind(Orientation orientation) : base(new List<FeatureBase> { new OrientationClockwiseFeature(orientation) })
        {
        }
        protected OrientationFeature HasOrientationFeature => (OrientationFeature)Features[0];

        public Orientation Orientation => HasOrientationFeature.Orientation;
    }
}
