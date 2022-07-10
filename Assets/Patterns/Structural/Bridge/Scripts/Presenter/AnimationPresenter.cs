

using UnityEngine;
using UnityEngine.UI;

namespace Patterns.Bridge
{
    public sealed class AnimationPresenter : MonoBehaviour
    {
        [SerializeField] private Image fadeImage; 
        [SerializeField] private Image bouncingImage;

        private void Start()
        {
            var anim1 =fadeImage.gameObject.AddComponent<Animatable>();
            var anim2 = bouncingImage.gameObject.AddComponent<Animatable>();

            anim1.Animation = new Fade(1);
            anim2.Animation = new Bouncing(1);

            anim1.Animate();
            anim2.Animate();
        }
    }
}
