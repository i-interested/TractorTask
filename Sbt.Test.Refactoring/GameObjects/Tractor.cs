using Sbt.Test.Refactoring.Base;
using Sbt.Test.Refactoring.Features;
using System.Collections.Generic;

namespace Sbt.Test.Refactoring.GameObjects
{
    public class Tractor : GameObject
    {
        private OrientationClockwiseFeature orientationFeature;
        private MoveForwardFeature moveForwardFeature;

        public Tractor(OrientationClockwiseFeature orientation, MoveForwardFeature positionFeature) : base(new List<FeatureBase> { orientation, positionFeature })
        {
            orientationFeature = orientation;
            moveForwardFeature = positionFeature;
        }

        public Orientation Orientation => orientationFeature.Orientation;

        public int GetPositionX()
        {
            return moveForwardFeature.GetPositionX();
        }

        public int GetPositionY()
        {
            return moveForwardFeature.GetPositionY();
        }
    }
}
