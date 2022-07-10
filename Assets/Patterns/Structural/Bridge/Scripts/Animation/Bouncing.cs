using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Patterns.Bridge
{
    public sealed class Bouncing : AnimationBase
    {
        private readonly Sequence sequence;
        private readonly Vector3[] scales = new Vector3[3]
        {
            new Vector3(0, 0, 0),
            new Vector3(1, 1, 1),
            new Vector3(1.5f, 1.5f, 1.5f)
        };



        public Bouncing(float duration) : base(duration)
        {
            sequence = DOTween.Sequence();
        }

        public override void Animate(Image image)
        {
            if (scales.Length == 0)
                return;
            float oneAnimationTime = duration / scales.Length;

            RectTransform rectTransform = image.rectTransform;

            sequence.Pause();
            for (int i = 0; i < scales.Length; i++)
            {
                sequence.Append(rectTransform.DOScale(scales[i], oneAnimationTime));
            }
            sequence.SetLoops(-1);
            sequence.Play();
        }
    }
}
