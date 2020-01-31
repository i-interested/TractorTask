using System.Collections.Generic;
using System.Linq;

namespace Sbt.Test.Refactoring.Base
{
    public abstract class GameObject
    {
        protected List<FeatureBase> Features = new List<FeatureBase>();
        public GameObject(IEnumerable<FeatureBase> commands)
        {
            Features.AddRange(commands);
        }
        public virtual void Move(string command)
        {
            var action = Features.FirstOrDefault(c => c.Validate(command));
            action?.DoAction();
        }
    }
}
