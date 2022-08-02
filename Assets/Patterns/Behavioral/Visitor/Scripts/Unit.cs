using UnityEngine;
using DG.Tweening;

namespace Patterns.Visitor
{
    public sealed class Unit : MonoBehaviour, IMovableEntity
    {
        public void Accept(IMovableEntityVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void MoveTo(Vector3 destination, float duration)
        {
            transform.DOMove(destination, duration).SetEase(Ease.Linear);
        }
    }
}
