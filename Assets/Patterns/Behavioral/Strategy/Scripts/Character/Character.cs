using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Strategy
{
    public class Character : MonoBehaviour, IMovable
    {
        protected IMovement movement;

        public event Action OnMovemntChanged;

        public IMovement Movement => movement;

        public virtual void SetMovement(IMovement movement)
        {
            this.movement = movement;
            OnMovemntChanged?.Invoke();
        }

        protected virtual void Update()
        {
            movement?.Move(transform);
        }
    }
}
