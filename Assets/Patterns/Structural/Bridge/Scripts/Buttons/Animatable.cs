using UnityEngine;

namespace Patterns.Bridge
{
    public class Animatable : MonoBehaviour
    {
        protected AnimationBase animation;

        public void SetAnimation(AnimationBase animation)
        {
            this.animation = animation;
            animation.Animate();
        }
    }
}
