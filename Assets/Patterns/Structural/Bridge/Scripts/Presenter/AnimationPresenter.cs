

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
            fadeImage.gameObject.AddComponent<Animatable>().Animation = new Fade(1);
            bouncingImage.gameObject.AddComponent<Animatable>().Animation = new Bouncing(1);
            
        }
    }
}
