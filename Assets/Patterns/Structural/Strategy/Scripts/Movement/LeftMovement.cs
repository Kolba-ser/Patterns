using UnityEngine;

namespace Patterns.Strategy
{
    public sealed class LeftMovement : IMovement
    {
        private readonly float speed;

        public LeftMovement(float speed)
        {
            this.speed = speed;
        }

        public void Move(Transform transform)
        {
            transform.Translate(-transform.right * speed * Time.deltaTime);
        }

        string IMovement.ToString() => nameof(LeftMovement);

    }
}
