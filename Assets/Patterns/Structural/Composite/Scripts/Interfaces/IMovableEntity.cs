using UnityEngine;

namespace Patterns.Composite
{
    public interface IMovableEntity
    {
        public void MoveTo(Vector3 destination, float duration);
    }
}