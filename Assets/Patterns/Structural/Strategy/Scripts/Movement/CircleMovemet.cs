using UnityEngine;

namespace Patterns.Strategy
{
    public sealed class CircleMovemet : IMovement
    {
        private float speed;
        private float angle;

        public CircleMovemet(float speed, float angle)
        {
            this.speed = speed;
            this.angle = angle;
        }

        public void Move(Transform transform)
        {
            transform.RotateAround(Vector3.zero, Vector3.up, angle * Time.deltaTime);
            transform.Translate(transform.forward * Time.deltaTime * speed);
        }

        string IMovement.ToString() => nameof(CircleMovemet);
    }
}
