using UnityEngine;

namespace Patterns.Strategy
{
    public sealed class ForwardMovement : IMovement
    {
        private readonly float speed;

        private Vector3? previosPosition = null;

        public ForwardMovement(float speed)
        {
            this.speed = speed;
        }

        public void Move(Transform transform)
        {
            transform.Translate(transform.forward * speed * Time.deltaTime);
        }

        string IMovement.ToString() => nameof(ForwardMovement);
    }
}
