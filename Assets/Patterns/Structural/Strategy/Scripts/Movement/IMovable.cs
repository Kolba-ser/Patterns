using UnityEngine;

namespace Patterns.Strategy
{
    public interface IMovable 
    {
        public void SetMovement(IMovement movement);
    }
}
