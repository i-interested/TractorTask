using Sbt.Test.Refactoring.Base;
using Sbt.Test.Refactoring.Features;
using Sbt.Test.Refactoring.GameObjects;

namespace Sbt.Test.Refactoring.Tests.Helpers
{
    public static class Helper
    {
        public static Tractor GetTractor()
        {
            var orientation = new OrientationClockwiseFeature(Orientation.North);
            var moveForward = new MoveForwardFeature(orientation, new Point(0, 0), new Size(5, 5));
            return new Tractor(orientation, moveForward);
        }
    }
}
