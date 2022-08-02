using UnityEngine;

namespace Patterns.Visitor
{
    public interface IMovableEntity
    {
        public void MoveTo(Vector3 destination, float duration);
        public void Accept(IMovableEntityVisitor visitor);
    }
}