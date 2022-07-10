using UnityEngine.UI;
using DG.Tweening;


namespace Patterns.Bridge
{
    public sealed class Fade : AnimationBase
    {
        private readonly Image image;
        private readonly float duration;
        private readonly Sequence sequence;

        public Fade(Image image, float duration)
        {
            this.image = image;
            this.duration = duration;
            sequence = DOTween.Sequence();
        }

        public override void Animate()
        {
            sequence.Pause();
            sequence.Append(image.DOFade(0, duration / 2));
            sequence.Append(image.DOFade(1, duration / 2));
            sequence.SetLoops(-1);
            sequence.Play();    
        }
    }
}
