using DG.Tweening;
using UnityEngine;

namespace Patterns.Bridge
{
    public sealed class Bouncing : AnimationBase
    {
        private readonly Transform transform;
        private readonly Sequence sequence;
        private readonly float duration;
        private readonly Vector3[] scales = new Vector3[3]
        {
            new Vector3(0, 0, 0),
            new Vector3(1, 1, 1),
            new Vector3(1.5f, 1.5f, 1.5f)
        };



        public Bouncing(Transform transform, float duration)
        {
            this.transform = transform;
            this.duration = duration;
            sequence = DOTween.Sequence();
        }

        public override void Animate()
        {
            if (scales.Length == 0)
                return;
            float oneAnimationTime = duration / scales.Length;

            RectTransform rectTransform = transform as RectTransform;

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
