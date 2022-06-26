using UnityEngine;

namespace Patterns.Strategy
{
    public sealed class StopMovement : IMovement
    {
        public void Move(Transform transform)
        {
            return;
        }

        string IMovement.ToString() => nameof(StopMovement);
    }
}