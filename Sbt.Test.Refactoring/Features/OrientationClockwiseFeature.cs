using Sbt.Test.Refactoring.Base;

namespace Sbt.Test.Refactoring.Features
{
    public class OrientationClockwiseFeature : OrientationFeature
    {
        public OrientationClockwiseFeature(Orientation orientation, string keyword = "T") : base(orientation, keyword)
        {
        }
        public override void DoAction()
        {
            if (orientation == Orientation.West)
                orientation = Orientation.North;
            else
                orientation += 1;
        }
    }
}
