using System;
using UnityEngine;

namespace Patterns.Strategy
{
    public sealed class MovementView : MonoBehaviour
    {
        [SerializeField] private Transform content;
        [SerializeField] private MovementButton button;

        public void Initialize(IMovement[] movements, Action<IMovement> onClick)
        {
            foreach (var movement in movements)
            {
                var created = Instantiate(button, content);
                created.Change += () => onClick(movement);
                created.SetContent(movement.ToString());
            }
        }
    }
}
