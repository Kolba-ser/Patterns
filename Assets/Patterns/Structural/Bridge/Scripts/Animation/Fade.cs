﻿using UnityEngine.UI;
using DG.Tweening;


namespace Patterns.Bridge
{
    public sealed class Fade : AnimationBase
    {
        private readonly Sequence sequence;

        public Fade(float duration) : base(duration)
        {
            sequence = DOTween.Sequence();
        }

        public override void Animate(Image image)
        {
            sequence.Pause();
            sequence.Append(image.DOFade(0, duration / 2));
            sequence.Append(image.DOFade(1, duration / 2));
            sequence.SetLoops(-1);
            sequence.Play();    
        }
    }
}
