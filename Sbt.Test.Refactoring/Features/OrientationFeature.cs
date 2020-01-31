using Sbt.Test.Refactoring.Base;

namespace Sbt.Test.Refactoring.Features
{
    public class OrientationFeature : FeatureBase
    {
        protected Orientation orientation;
        public Orientation Orientation => orientation;
        public OrientationFeature(Orientation orientation, string keyword = null) : base(keyword)
        {
            this.orientation = orientation;
        }

        public override void DoAction()
        {
        }
    }
}
