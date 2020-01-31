using Sbt.Test.Refactoring.Base;

namespace Sbt.Test.Refactoring.Features
{
    public class PositionFeature : FeatureBase
    {
        protected Point position;
        protected Size field;
        public PositionFeature(Point startPosition, Size fieldSize, string keyword = null) : base(keyword)
        {
            position = startPosition;
            field = fieldSize;
        }

        public override void DoAction()
        {
        }

        public int GetPositionX()
        {
            return position.X;
        }

        public int GetPositionY()
        {
            return position.Y;
        }
    }
}
