using UnityEngine;
using DG.Tweening;

namespace Patterns.Composite
{
    public sealed class Unit : MonoBehaviour, IMovableEntity
    {
        public void MoveTo(Vector3 destination, float duration)
        {
            transform.DOMove(destination, duration).SetEase(Ease.Linear);
        }
    }
}
