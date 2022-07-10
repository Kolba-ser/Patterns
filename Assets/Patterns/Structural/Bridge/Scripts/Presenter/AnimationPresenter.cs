

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
            AnimationBase fade = new Fade(fadeImage, 1);
            AnimationBase bouncing = new Bouncing(bouncingImage.transform, 1);

            fadeImage.gameObject.AddComponent<Animatable>().SetAnimation(fade);
            bouncingImage.gameObject.AddComponent<Animatable>().SetAnimation(bouncing);
            
        }
    }
}
