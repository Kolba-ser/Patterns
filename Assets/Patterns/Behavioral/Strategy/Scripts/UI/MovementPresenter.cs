using System;
using TMPro;
using UnityEngine;

namespace Patterns.Strategy
{
    public sealed class MovementPresenter : MonoBehaviour
    {
        [SerializeField] private Character character;
        [Space(20)]
        [SerializeField] private TextMeshProUGUI movementContent;
        [Space(20)]
        [SerializeField] private MovementView view;

        private void OnEnable()
        {
            character.OnMovemntChanged += OnMovemntChanged;
        }

        private void OnDisable()
        {
            character.OnMovemntChanged -= OnMovemntChanged;
        }

        private void OnMovemntChanged()
        {
            movementContent.text = character.Movement.ToString();
        }

        public void Initialize(IMovement[] movements)
        {
            view.Initialize(movements, ChangeMovement);
        }

        private void ChangeMovement(IMovement movement)
        {
            character.SetMovement(movement);
        }
    }
}
