using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Strategy
{
    public sealed class Bootstraper : MonoBehaviour
    {
        [SerializeField] private MovementPresenter presenter;

        [SerializeField] private float speed;
        [Header("CircleMovement")]
        [SerializeField] private float angle;

        private void Awake()
        {
            List<IMovement> movements = new List<IMovement>(3);

            movements.Add(new CircleMovemet(speed, angle));
            movements.Add(new ForwardMovement(speed));
            movements.Add(new BackwardMovement(speed));
            movements.Add(new RightMovement(speed));
            movements.Add(new LeftMovement(speed));
            movements.Add(new StopMovement());

            presenter.Initialize(movements.ToArray());
        }
    }
}
