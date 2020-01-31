using Sbt.Test.Refactoring.Base;
using Sbt.Test.Refactoring.Exceptions;

namespace Sbt.Test.Refactoring.Features
{
    public class MoveForwardFeature : PositionFeature
    {
        public MoveForwardFeature(OrientationFeature orientationFeature, Point startPosition, Size fieldSize, string keyword = "F") : base(startPosition, fieldSize, keyword)
        {
            this.orientationFeature = orientationFeature;
        }

        protected OrientationFeature orientationFeature { get; }

        public override void DoAction()
        {
            switch (orientationFeature.Orientation)
            {
                case Orientation.North:
                    position.Y++;
                    break;
                case Orientation.East:
                    position.X++;
                    break;
                case Orientation.South:
                    position.Y--;
                    break;
                case Orientation.West:
                    position.X--;
                    break;
            }

            if (position.X > field.Width
                || position.Y > field.Height)
            {
                throw new OutsideMoveException();
            }
        }
    }
}
