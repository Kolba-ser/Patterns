using UnityEngine;

namespace Patterns.Strategy
{
    public interface IMovement
    {
        public void Move(Transform transform);

        public string ToString();
    }
}
