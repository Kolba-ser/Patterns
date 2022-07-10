using UnityEngine.UI;

namespace Patterns.Bridge
{
    public abstract class AnimationBase
    {
        protected readonly float duration;

        protected AnimationBase(float duration)
        {
            this.duration = duration;
        }

        public abstract void Animate(Image image);
    }
}
