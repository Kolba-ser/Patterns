using UnityEngine;

namespace Patterns.Strategy
{
    public sealed class BackwardMovement : IMovement
    { 
        private readonly float speed;

        public BackwardMovement(float speed)
        {
            this.speed = speed;
        }

        public void Move(Transform transform)
        {
            transform.Translate(-transform.forward * speed * Time.deltaTime);
        }

        string IMovement.ToString() => nameof(BackwardMovement);

    }
}
