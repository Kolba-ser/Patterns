using UnityEngine;

namespace Patterns.Strategy
{
    public sealed class RightMovement : IMovement
    {
        private readonly float speed;

        private Vector3? previosPosition = null;

        public RightMovement(float speed)
        {
            this.speed = speed;
        }

        public void Move(Transform transform)
        {
            transform.Translate(transform.right * speed * Time.deltaTime);
        }

        string IMovement.ToString() => nameof(RightMovement);
    }
}
