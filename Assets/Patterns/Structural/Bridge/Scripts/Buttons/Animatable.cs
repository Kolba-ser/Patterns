using UnityEngine;
using UnityEngine.UI;

namespace Patterns.Bridge
{
    [RequireComponent(typeof(Image))]
    public class Animatable : MonoBehaviour
    {
        public AnimationBase Animation { get; set; }

        protected Image image;

        protected virtual void Awake()
        {
            image = GetComponent<Image>();
        }

        public virtual void Animate()
        {
            Animation.Animate(image);
        }
    }
}
